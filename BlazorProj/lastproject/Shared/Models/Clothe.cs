namespace lastproject.Shared.Models
{
    public class Clothe
    {
        public int number = 0;
        public string Name { get; set; }
        public int Price { get; set; }
        public int Id { get; set; }
        public int count { get; set; }
        public string Link { get; set; }

        

        public override bool Equals(object obj)
        {
            var other = obj as Clothe;
            if (other == null)
                return false;
            return this.Id == other.Id;
        }

        public override int GetHashCode() =>
            this.Id;

        public override string ToString() =>
            $"{this.Id} {this.Name} {this.Price}";
    }
}