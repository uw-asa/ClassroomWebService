using Microsoft.Restier.EntityFramework;

namespace ClassroomWebService.Models
{
    public class ClassroomApi : DbApi<ClassroomContext>
    {
        public ClassroomContext Context
        {
            get { return DbContext; }
        }
    }
}