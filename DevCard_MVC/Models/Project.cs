namespace DevCard_MVC.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descrption { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }

        public Project(int id, string nameTitle, string descrption, string client, string image)
        {
            Id = id;
            Name = nameTitle;
            Descrption = descrption;
            Client = client;
            Image = image;
        }
    }
}
