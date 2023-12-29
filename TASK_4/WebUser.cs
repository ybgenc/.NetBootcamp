namespace netBootcamp.TASK_4
{
    public class WebUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
