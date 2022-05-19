using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    class UserEntity
    {
        public int id = 1;
        public string fullname = "SurtinJS";
        public string phone = "0123456789";
        public string avatar;
        public string password = "123456";
        public DateTime birthdate;
        public bool gender;
        public string address;
        public long salary;
        public bool is_admin;
        public bool enabled;
        public DateTime created_at;
        public DateTime updated_at;


        public UserEntity setId(int id)
        {
            this.id = id;
            return this;
        }

        public UserEntity setFullName(string fullname)
        {
            this.fullname = fullname;
            return this;
        }

        public UserEntity setPhone(string phone)
        {
            this.phone = phone;
            return this;
        }

        public UserEntity setAvatar(string avatar)
        {
            this.avatar = avatar;
            return this;
        }

        public UserEntity setPassword(string password)
        {
            this.password = password;
            return this;
        }

        public UserEntity setBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;
            return this;
        }

        public UserEntity setGender(bool gender)
        {
            this.gender = gender;
            return this;
        }

        public UserEntity setAddress(string address)
        {
            this.address = address;
            return this;
        }

        public UserEntity setSalary(long salary)
        {
            this.salary = salary;
            return this;
        }

        public UserEntity setIs_admin(bool is_admin)
        {
            this.is_admin = is_admin;
            return this;
        }

        public UserEntity setEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
        }

        public UserEntity setCreated_at(DateTime created_at)
        {
            this.created_at = created_at;
            return this;
        }

        public UserEntity setUpdated_at(DateTime updated_at)
        {
            this.updated_at = updated_at;
            return this;
        }
    }
}
