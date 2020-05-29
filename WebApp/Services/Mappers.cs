using System;
using System.Collections.Generic;
using System.Linq;
using WebApp.Models;

namespace WebApp.Services
{
    public static class Mappers
    {
        public static User BuildUser(UserModel u)
        {
            return new User
            {
                NickName = u.NickName,
                Password = u.Password,
                Email = u.Email,
                //FriendsOut = u.Friends1,
                //FriendsIn = u.Friends2,
                Id = u.Id,
                Path = u.Path,
                subscribersQuantity = u.subscribersQuantity,
                subscriptionsQuantity = u.subscriptionsQuantity
                //LikesPosts = u.LikesPosts,
                //InputSubscriptions = u.InputSubscriptions,
                //OutputSubcriptions = u.OutputSubscribtions,
                //Posts = u.Posts
                // age = u.age,
                //birthday = u.birthday
            };
        }
        public static Message BuildMessage(MessageModel m)
        {
            return new Message
            {
                Id = m.Id,
                OwnerDialogId = m.OwnerDialogId,
                SendingTime = m.SendingTime,
                Text = m.Text,
                OwnerId = m.OwnerId
            };
        }

        public static Dialog BuildDialog(DialogModel d)
        {
            return new Dialog
            {
                Id = d.Id,
                FirstPersonId = d.FirstPersonId,
                SecondPersonId = d.SecondPersonId
            };
        }
        public static User BuildUserInformation(UserModel u)
        { 
            var a = new User
            {
                NickName = u.NickName,
                Email = u.Email,
                Id = u.Id,
                Path = u.Path,
                subscribersQuantity = u.subscribersQuantity,
                subscriptionsQuantity = u.subscriptionsQuantity
            };
            return a;
        }
        public static Post BuildPost(PostModel p)
        {
            var a = new Post
            {
                Time = DateTime.Parse(p.Time),
                Id = p.Id,
                Owner = BuildUserInformation(p.Owner),
                Rating = p.Rating,
                Text = p.Text,
                OwnerId = p.OwnerId
            };
            return a;
        }
        
    }
}