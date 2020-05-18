namespace Lab_Week_05
{
    public class Movie
    {
        private string _title;
        private string _category;

        public Movie(string title, string category)
        {
            _title = title;
            _category = category;
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetCategory()
        {
            return _category;
        }
    }
}
