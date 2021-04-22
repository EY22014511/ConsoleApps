using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App04
{
    public class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// Displays a menu for the user to select their choice
        /// </summary>
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
                    case 5: AddComment(); break;
                    case 6: LikePost(); break;
                    case 7: UnlikePost(); break;
                    case 8: RemovePost(); break;
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// a method which Removes a post
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a Post");

            int id = (int)ConsoleHelper.InputNumber(" Please enter the post id > ", 
                                                        1, Post.GetNumberOfPosts());

            news.RemovePost(id);
        }

        /// <summary>
        /// a method which Unlikes a psot
        /// </summary>
        private void UnlikePost()
        {
            ConsoleHelper.OutputTitle("Unliking a Post");
            Post post = FindPost();

            post.Unlike();
        }

        /// <summary>
        /// a method which likes a post
        /// </summary>
        private void LikePost()
        {
            ConsoleHelper.OutputTitle("Liking a Post");
            Post post = FindPost();

            post.Like();
        }

        /// <summary>
        /// method to find the post by its ID
        /// </summary>
        public Post FindPost()
        {
            int postID;
            postID = (int)ConsoleHelper.InputNumber("Enter the ID of the post");
            return news.FindPost(postID);
        }

        /// <summary>
        /// a method to add a comment to a post
        /// </summary>
        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Adding a Comment");
            Post post = FindPost();
            post.Display();

            Console.WriteLine("Enter Comment > ");
            string comment = Console.ReadLine();
            post.AddComment(comment);
        }

        /// <summary>
        /// method to display all posts by a certain author
        /// </summary>
        private void DisplayByAuthor()
        {
            Console.WriteLine("Who'a posts do you want to see? > ");
            string author = Console.ReadLine();

            news.FindPostByUser(author);
        }

        /// <summary>
        /// a mtheod to display all the posts
        /// </summary>
        private void DisplayAll()
        {
            news.Display();
        }

        /// <summary>
        /// a method to post an image with a caption
        /// </summary>
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Posting an Image/Photo");

            string author = InputName();

            Console.Write(" Please enter your image filename > ");
            string filename = Console.ReadLine();

            Console.Write(" Please enter your image caption > ");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("You have just posted this image: ");
            post.Display();
        }

        /// <summary>
        /// a method to post a message
        /// </summary>
        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Posting a Message");

            string author = InputName();

            Console.Write(" Please enter your message > ");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("You have just posted this message: ");
            post.Display();
        }

        /// <summary>
        /// a method to allow the user to set their name as an author of a post
        /// </summary>
        /// <returns></returns>
        private string InputName()
        {
            Console.Write(" Please enter your name > ");
            string author = Console.ReadLine();

            return author;
        }
    }
}
