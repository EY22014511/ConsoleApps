﻿using System;
using System.Collections.Generic;
namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int PostId { get; }

        private static int instances = 0;

        private int likes;
        private readonly List<String> comments;

        /// <summary>
        /// 
        /// </summary>
        public String Username { get; }

        public DateTime Timestamp { get; }

        /// <summary>
        /// 
        /// </summary>
        public Post(string author)
        {
            instances++;
            PostId = instances;
            
            
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Like()
        {
            likes++;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        public static int GetNumberOfPosts()
        {
            return instances;
        }

        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"    Author: {Username}");
            Console.WriteLine($"    Time Elpased: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count}  comment(s). Click here to view.");
            }
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
    }
}
