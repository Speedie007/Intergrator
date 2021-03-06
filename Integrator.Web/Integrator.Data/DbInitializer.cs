﻿using Integrator.Data.Interfaces;
using Integrator.Models.Domain.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Integrator.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly IServiceProvider _serviceProvider;

        public DbInitializer(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        //This example just creates an Administrator role and one Admin users
        public async void Initialize()
        {
            using (var serviceScope = _serviceProvider.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                //create database schema if none exists
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();

                //If there is already an Administrator role, abort
                var _roleManager = serviceScope.ServiceProvider.GetService<RoleManager<IntegratorRole>>();
                if (!(await _roleManager.RoleExistsAsync("Administrator")))
                {
                    //Create the Administartor Role
                    await _roleManager.CreateAsync(new IntegratorRole("Administrator"));
                }
                if (!(await _roleManager.RoleExistsAsync("Individual")))
                {
                    //Create the Individual Role
                    await _roleManager.CreateAsync(new IntegratorRole("Individual"));
                }
                if (!(await _roleManager.RoleExistsAsync("Agent")))
                {
                    //Create the Agent Role
                    await _roleManager.CreateAsync(new IntegratorRole("Agent"));
                }
                if (!(await _roleManager.RoleExistsAsync("Company")))
                {
                    //Create the Agent Role
                    await _roleManager.CreateAsync(new IntegratorRole("Company"));
                }
                //Create the default Admin account and apply the Administrator role
                var _userManager = serviceScope.ServiceProvider.GetService<UserManager<IntegratorUser>>();
                string user = "Admin@Admin.com";
                string password = "Speedie@007";
                var success = await _userManager.CreateAsync(new IntegratorUser { UserName = user, Email = user, EmailConfirmed = true }, password);
                if (success.Succeeded)
                {
                    await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(user), "Administrator");
                }
                user = "a@a.com";
                password = "Speedie@007";
                success = await _userManager.CreateAsync(new IntegratorUser
                {
                    UserName = user,
                    Email = user,
                    EmailConfirmed = true,
                    FirstName = "Agent",
                    LastName = "Wood,"
                }, password);
                if (success.Succeeded)
                {
                    await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(user), "Agent");
                }
                user = "Brendanw@mweb.co.za";
                password = "Speedie@007";
                success = await _userManager.CreateAsync(new IntegratorUser
                {
                    UserName = user,
                    Email = user,
                    EmailConfirmed = true,
                    FirstName = "Brendan",
                    LastName = "Wood,"
                }, password);
                if (success.Succeeded)
                {
                    await _userManager.AddToRoleAsync(await _userManager.FindByNameAsync(user), "Individual");
                }
            }
        }
    }
}