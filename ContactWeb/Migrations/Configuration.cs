namespace ContactWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ContactWeb.Models.ContactWebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ContactWeb.Models.ContactWebContext";
        }

        protected override void Seed(ContactWeb.Models.ContactWebContext context)
        {

            /*
             * b16ae954-8beb-4c8e-9939-0961d622dec3
             * 71989cc0-54e6-4106-9264-3dddb28dbc78
             */
            context.Contacts.AddOrUpdate(
                p => p.Id,
                new Models.Contact
                {
                    Id = 1,
                    Birthday = new DateTime(1920, 01, 20),
                    City = "Chicago"
                                    ,
                    Email = "doc.mccoy@starfleet.com",
                    FirstName = "DeForest",
                    LastName = "Kelley"
                                    ,
                    PhonePrimary = "123-456-7890",
                    PhoneSecondary = "234-567-8901",
                    State = "IL"
                                    ,
                    StreetAddress1 = "Sickbay",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("b16ae954-8beb-4c8e-9939-0961d622dec3")
                                    ,
                    Zip = "98765"
                }
                , new Models.Contact
                {
                    Id = 2,
                    Birthday = new DateTime(1920, 03, 03),
                    City = "New York"
                                    ,
                    Email = "i.beam.you.up@starfleet.com",
                    FirstName = "James",
                    LastName = "Doohan"
                                    ,
                    PhonePrimary = "345-678-9012",
                    PhoneSecondary = "456-789-0123",
                    State = "NY"
                                    ,
                    StreetAddress1 = "Engineering",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("b16ae954-8beb-4c8e-9939-0961d622dec3")
                                    ,
                    Zip = "87654"
                }
                , new Models.Contact
                {
                    Id = 3,
                    Birthday = new DateTime(1931, 03, 26),
                    City = "Los Angeles"
                                    ,
                    Email = "its.only.logic@starfleet.com",
                    FirstName = "Leonard",
                    LastName = "Nimoy"
                                    ,
                    PhonePrimary = "987-654-3210",
                    PhoneSecondary = "876-543-2109",
                    State = "CA"
                                    ,
                    StreetAddress1 = "Science Station 1",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("71989cc0-54e6-4106-9264-3dddb28dbc78")
                                    ,
                    Zip = "76543-2109"
                }
                , new Models.Contact
                {
                    Id = 4,
                    Birthday = new DateTime(1931, 03, 22),
                    City = "Riverside"
                                    ,
                    Email = "the.captain@starfleet.com",
                    FirstName = "William",
                    LastName = "Shatner"
                                    ,
                    PhonePrimary = "765-432-1098",
                    PhoneSecondary = "654-321-0987",
                    State = "IA"
                                    ,
                    StreetAddress1 = "The Bridge",
                    StreetAddress2 = "Starship Enterprise NCC-1701"
                                    ,
                    UserId = new Guid("71989cc0-54e6-4106-9264-3dddb28dbc78")
                                    ,
                    Zip = "65432-0123"
                }
            );
        }
    }
}
