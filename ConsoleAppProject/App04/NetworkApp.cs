using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void DisplayMenu()
        {
            ConsoleHelper.OutputHeading("     Edrick's News Feed");

            string[] choices = new string[]
                {
                    "Post Message", "Post Image", "" +
                    "Display All Posts", "Display by Author", "" +
                    "", "Add Comment(s)", "Like a Post", "" +
                    "Unlike a Post", "Remove a Post", "Quit"
                };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);

                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: DisplayAll(); break;
                    case 4: DisplayByAuthor(); break;
                    case 5: DisplayByDate(); break;
                    case 6: AddComment(); break;
                    case 7: LikePost(); break;
                    case 8: UnlikePost(); break;
                    case 9: RemovePost(); break;
                    case 10: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void RemovePost()
        {
            throw new NotImplementedException();
        }

        private void UnlikePost()
        {
            throw new NotImplementedException();
        }

        private void LikePost()
        {
            throw new NotImplementedException();
        }

        private void AddComment()
        {
            throw new NotImplementedException();
        }

        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }

        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }

        private void DisplayAll()
        {
            news.Display();
        }

        private void PostImage()
        {
            throw new NotImplementedException();
        }

        private void PostMessage()
        {
            throw new NotImplementedException();
        }
    }
}
