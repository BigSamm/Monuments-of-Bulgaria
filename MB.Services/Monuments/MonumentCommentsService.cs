﻿namespace MB.Services.Monuments
{
    using System;
    using System.Linq;
    
    using Contracts.Monuments;
    using Data;
    using Models;
    using Models.Monuments;

    public class MonumentCommentsService : IMonumentCommentsService
    {
        private readonly MbDbContext dbContext;

        public MonumentCommentsService(MbDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<MonumentComment> GetAllForMonumentOrderedByDateDescending(int monumentId)
        {
            return this.dbContext.MonumentComments
                .Where(x => x.MonumentId == monumentId)
                .Where(x => x.IsDeleted == false)
                .OrderByDescending(x => x.CreatedOn);
        }

        public void Create(int monumentId, string content, string username)
        {
            if (!this.dbContext.Monuments.Any(x => x.Id == monumentId))
                throw new ArgumentNullException(nameof(monumentId));
            
            MbUser user = this.dbContext.Users.FirstOrDefault(x => x.UserName == username);
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var monumentComment = new MonumentComment
            {
                Content = content,
                MonumentId = monumentId,
                UserId = user.Id,
            };

            this.dbContext.MonumentComments.Add(monumentComment);
            this.dbContext.SaveChanges();
        }

        public void Like(int commentId, string username)
        {
            MonumentComment comment = this.dbContext.MonumentComments.FirstOrDefault(x => x.Id == commentId);
            if (comment == null)
                throw new ArgumentNullException(nameof(comment));
            
            MbUser user = this.dbContext.Users.FirstOrDefault(x => x.UserName == username);
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            var like = new MonumentCommentLike
            {
                MonumentCommentId = commentId,
                UserId = user.Id,
            };

            this.dbContext.MonumentCommentLikes.Add(like);
            this.dbContext.SaveChanges();
        }

        public bool CheckForExistingLike(int commentId, string username)
        {
            MbUser user = this.dbContext.Users.FirstOrDefault(x => x.UserName == username);

            if (user == null)
                throw new ArgumentNullException(nameof(user));

            bool result = this.dbContext.MonumentComments.Any(x => x.Id == commentId && x.User == user);
            return result;
        }
    }
}
