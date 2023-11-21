namespace project_manage_system_backend.Dtos
{
    public class ProjectResultDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int Members { get; set; }

        //新增:封面圖數據
        public byte[] CoverImage { get; set; }

    }
}
