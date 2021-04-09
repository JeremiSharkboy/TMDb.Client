using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMDB.Core.API.Web
{

    [Table("Users")]
    public class User : IUser
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
        }

        [Key]
        public string Id { get; }

        public uint CommentsCount { get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    [Table("Comment")]
    public class Comment
    {
        public Comment()
        {
            Time = DateTime.Now;
        }

        [Key]
        public int CommentId { get; set; }

        public string UserId { get; set; }

        [NotMapped]
        public virtual User User { get; set; }

        public uint MoiveId { get; set; }

        public string Text { get; set; }

        public DateTime Time { get; set; }
    }

    [Table("Like")]
    public class Like
    {
        [Key]
        public int Id { get; }

        public string UserId { get; set; }

        public uint MoiveId { get; set; }

        public bool Tv { get; set; }
    }

    [Table("Stats")]
    public class Stats
    {
        [Key]
        public int Id { get; }

        public bool IsTV { get; set; } = false;

        public string Title { get; set; }

        public uint MovieId { get; set; }

        public uint ViewCount { get; set; } = 1;
        public uint TotalLikes { get; set; } = 0;
        public uint CommentsCount { get; set; } = 0;
        public DateTime LastOpen { get; set; } = DateTime.Now;

    }


    public class TopStats
    {
        public List<Stats> TopLikes { get; set; }
        public List<Stats> TopComments { get; set; }
        public List<Stats> TopViews { get; set; }
    }
}