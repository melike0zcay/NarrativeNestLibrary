﻿namespace NarrativeNest.Models.Entities
{
    public class Favorite
    {
        public Guid FavoriteID { get; set; }  // Primary Key

        // Foreign Keys
        public Guid UserId { get; set; }  // Foreign Key to Users
        public Guid BookId { get; set; }  // Foreign Key to Books

        // Navigation Properties
        public User User { get; set; }   // Navigation Property to User
        public Books Book { get; set; }   // Navigation Property to Book
    }
}
