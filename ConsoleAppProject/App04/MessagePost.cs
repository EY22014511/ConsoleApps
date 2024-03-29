﻿using System;
namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// version 0.1
    /// </author>
    public class MessagePost : Post
    {
       public String Message { get; }

        public MessagePost(String author, String text):base(author)
        {            
            Message = text;
        }

        public override void Display()
        {
            Console.WriteLine($"     Message: {Message}");

            base.Display();
        }
    }
}
