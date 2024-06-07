namespace Admin_Pannel_Embeded.Models
{
    public class Nav
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Action { get; set; }
        public List<Nav> SideBar()
        {
            List<Nav> SideList = new List<Nav>()
            {
                new Nav{Id=1,Name="DashBoard V1",Action="Index"},
                new Nav{Id=2,Name="DashBoard V2",Action="IndexV1"},
            };
            return SideList;
        }
        public List<Nav> NavFun()
        {
            List<Nav> NavList = new List<Nav>()
            {
                new Nav() { Id = 1, Name = "Home V1", Action = "Index" },
                new Nav() { Id = 2, Name = "Home V2", Action = "IndexV1" }
            };
            return NavList;
        }

    }
    
}
