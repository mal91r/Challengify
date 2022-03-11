﻿using System;
using System.Collections.Generic;
using System.Text;
using Challengify.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Challengify.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Challenges = new List<Challenge>();
            Challenges.Add(new Challenge
            {
                Id = "1",
                Name = "pushups",
                Image = "c:/asdmks/",
                ShortDescription = "updown",
                FullDescription = "up and down",
                MaxParticipants = 3,
                SumOfXP = 10
            });
            Challenges.Add(new Challenge
            {
                Id = "2",
                Name = "waterbottleflip challenge",
                Image = "c:/asdmks/",
                ShortDescription = "flip",
                FullDescription = "flip-flop",
                MaxParticipants = 5,
                SumOfXP = 20
            });
            Users = new List<User>();
            Users.Add(new User
            {
                //Id = "testIdUser",
                Username = "artem777",
                Email = "artem@mail.com",
                UserChallenges = new List<Challenge>(),
                IsSubcriber = false,
                XP = 0
            });
            Users.Add(new User
            {
                //Id = "testIdUser",
                Username = "vladimir191",
                Email = "vladimir@mail.com",
                UserChallenges = new List<Challenge>(),
                IsSubcriber = false,
                XP = 0
            });
        }

        public DbSet<User> DbUsers { get; set; }

        public DbSet<Challenge> DbChallenges { get; set; }

        public List<Challenge> Challenges;
        public new List<User> Users;

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite("Data Source=app.db");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>().HasData(new User
            {
                //Id = "testIdUser",
                Username = "nickname",
                Email = "mail@mail.com",
                //IsSubcriber = false,
                XP = 0
            });

            builder.Entity<Challenge>().HasData(new Challenge
            {
                Id = "testIdChallenge",
                Name = "challenge name",
                Image = "c:/asdmks/",
                ShortDescription = "short description",
                FullDescription = "full desc",
                MaxParticipants = 3,
                SumOfXP = 10
            });
        }
    }
}
