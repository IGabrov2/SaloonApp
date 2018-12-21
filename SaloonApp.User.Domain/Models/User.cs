using System;
using SaloonApp.Common.Extensions;
using System.ComponentModel.DataAnnotations;

namespace SaloonApp.UserDom.Domain.Models
{
    public class User
    {
        private CustomId _id;

        [Key]
        public string Id
        {
            get { return this._id.ToString(); }
            private set { this._id = new CustomId(new Guid(value)); }
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return this.FirstName + " " + this.LastName; }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PictureURL { get; set; }
        public TypeOfUser TypeOfUser { get; set; }
        public string  ValidationCode { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public DateTime? DateCreated { get; private set; }

        public User() { }

        public User(string FirstName,string LastName, string email, string password, TypeOfUser typeOfUser, string validationCode = null,
            bool isEmailConfirmed = false, CustomId id = null)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = email;
            this.Password = password;
            this.TypeOfUser = typeOfUser;
            this.ValidationCode = validationCode;
            this.IsEmailConfirmed = isEmailConfirmed;
            this.DateCreated = DateTime.Now;
            this._id = id ?? new CustomId();
        }
        public User(string email, TypeOfUser typeOfUser)
        {
            this.Email = email;
            this.TypeOfUser = typeOfUser;
        }
        public User(string firstName, string lastName, string email, string password, TypeOfUser typeOfUser, string validationCode, bool IsEmailConfirmed,string pictureURL ,CustomId customId, DateTime now)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            this.TypeOfUser = typeOfUser;
            ValidationCode = validationCode;
            this.IsEmailConfirmed = IsEmailConfirmed;
            this.PictureURL = pictureURL;
            this._id = customId ?? new CustomId();
            this.DateCreated = now;
        }
        public User(string firstName, string lastName, string email, string password, TypeOfUser typeOfUser, string validationCode, bool IsEmailConfirmed, CustomId customId, DateTime now)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            this.TypeOfUser = typeOfUser;
            ValidationCode = validationCode;
            this.IsEmailConfirmed = IsEmailConfirmed;
            this._id = customId ?? new CustomId();
            this.DateCreated = now;
        }
    }
}
