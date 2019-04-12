﻿using BreakinIn.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RevivinSun.Model
{
    public class UserCollection
    {
        protected List<User> Users = new List<User>();

        public List<User> GetAll()
        {
            lock (Users)
            {
                return new List<User>(Users);
            }
        }

        public virtual bool AddUser(User user)
        {
            lock (Users)
            {
                Users.Add(user);
            }
            return true;
        }

        public virtual void RemoveUser(User user)
        {
            lock (Users)
            {
                Users.Remove(user);
            }
        }

        public User GetUserByName(string name)
        {
            lock (Users)
            {
                return Users.FirstOrDefault(x => x.Username == name);
            }
        }

        public User GetUserByPersonaName(string name)
        {
            lock (Users)
            {
                return Users.FirstOrDefault(x => x.PersonaName == name);
            }
        }

        public int Count()
        {
            lock (Users)
            {
                return Users.Count;
            }
        }

        public void Broadcast(AbstractMessage msg)
        {
            var data = msg.GetData();
            lock (Users)
            {
                foreach (var user in Users)
                {
                    user.Connection?.SendMessage(data);
                }
            }
        }
    }
}
