using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using System.Net.Http;
using Integrator.Services.Users;
using Integrator.Models.ViewModels.ViewModelBaseComponents;
using Integrator.Models.Domain.Files;
using Integrator.Models.ViewModels.Common;
using Integrator.Models.ViewModels.Common.Files;

namespace Integrator.Web.Controllers
{
    public class ImageProcessingController : Controller
    {

        #region Fields
        private readonly IUserService _userService;
        private IEntityCRUDResponse _entityCRUDResponse;
        #endregion

        #region Cstor
        public ImageProcessingController(
            IUserService userService,
            IEntityCRUDResponse entityCRUDResponse
            )
        {
            this._userService = userService;
            this._entityCRUDResponse = entityCRUDResponse;
        }
        #endregion

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UploadUserProfileImage([FromBody] UserProifileImageUploadRequest request)
        {
            byte[] NewImage = Convert.FromBase64String(request.ImageData);
            _entityCRUDResponse = _userService.AddUserProfilePicture(new IntegratorFile()
            {
                ContentType = request.FileType,
                DateCreated = DateTime.Now,
                FileSize = NewImage.Length,
                FileExtension = Path.GetExtension(request.FileName).Replace(".", ""),
                FileName = Path.GetFileNameWithoutExtension(request.FileName),
                InegratorFileBlob = new InegratorFileBlob()
                {
                    FileBlob = NewImage
                },
                UserPicture = new UserPicture()
                {
                    IntegratorUserID = _userService.GetUserID(),
                    IsCurrentProfilePicture = true
                }
            });

            return new JsonResult(_entityCRUDResponse);
        }
        public async Task<IActionResult> Index(int FileID, int sourceX, int sourceY, int sourceWidth, int sourceHeight, int destinationWidth, int destinationHeight)
        {

            using (Image sourceImage = await this.LoadImageFromDB())
            {
                if (sourceImage != null)
                {
                    try
                    {
                        using (Image destinationImage = this.CropImage(sourceImage, sourceX, sourceY, sourceWidth, sourceHeight, destinationWidth, destinationHeight))
                        {
                            MemoryStream outputStream = new MemoryStream();

                            byte[] CroppedImage = outputStream.ToArray();

                            destinationImage.Save(outputStream, ImageFormat.Jpeg);
                            outputStream.Seek(0, SeekOrigin.Begin);


                            return this.File(outputStream, "image/png");
                        }
                    }

                    catch
                    {
                        // Add error logging here
                    }
                }
            }

            return this.NotFound();
        }

        private async Task<Image> LoadImageFromDB()
        {
            Image image = null;

            try
            {
                //using (HttpClient httpClient = new HttpClient())
                //using (HttpResponseMessage response = await httpClient.GetAsync(url))
                //using (Stream inputStream = await response.Content.ReadAsStreamAsync())
                //using (Bitmap temp = new Bitmap(inputStream))


                MemoryStream ms = new MemoryStream(await _userService.GetUserProfilePictureAsync());

                image = new Bitmap(ms);
            }

            catch
            {
                // Add error logging here
            }

            return image;
        }

        private Image CropImage(Image sourceImage, int sourceX, int sourceY, int sourceWidth, int sourceHeight, int destinationWidth, int destinationHeight)
        {
            Image destinationImage = new Bitmap(destinationWidth, destinationHeight);

            using (Graphics g = Graphics.FromImage(destinationImage))
                g.DrawImage(
                  sourceImage,
                  new Rectangle(0, 0, 480, destinationHeight),
                  new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                  GraphicsUnit.Pixel
                );

            //using (Graphics g = Graphics.FromImage(destinationImage))
            //    g.DrawImage(
            //      sourceImage,
            //      new Rectangle(0, 0, destinationWidth, destinationHeight),
            //      new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
            //      GraphicsUnit.Pixel
            //    );

            return destinationImage;
        }
    }
}