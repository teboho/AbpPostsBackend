using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxfusion.Posts.Domain
{
    public class Car : Entity<long>
    {
        // Id is ABP primary key
        public long PersonId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public Person PersonModel { get; set; }
    }
}
