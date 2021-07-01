using System;

namespace Social_Network
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            //Methode aufrufen
            Post post = new Post();
            //post.Text für die Set Methode     Text wird aufgerufen um text zu setten
            post.Text = postText;
            //Methode aufrufen und ausführen Console.Writeline(text); 
            post.ShowPost();
        }
    }

    class Post
    {
        private string text;
       //Schreibt "New Post" und darunter kommt der neue post
        public Post()
        {
            Console.WriteLine("New post");
        }
        //Methode um den Post zu erstellen
        public void ShowPost()
        {
            Console.WriteLine(text) ;
        }
        // um die private string text zu benutzen
        public string Text
        {
            get { return text; }
            set { text = value; }
        }


    }
}
