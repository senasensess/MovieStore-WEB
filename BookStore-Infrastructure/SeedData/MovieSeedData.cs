using BookStore_ApplicationCore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_Infrastructure.SeedData
{
    public class MovieSeedData : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasData
                (
                    new Movie { Id = 1,  DirectorId = 1, Name = "Full Metal Jacket", Year = 1987, Description = "A pragmatic U.S. Marine observes the dehumanizing effects the Vietnam War has on his fellow recruits from their brutal boot camp training to the bloody street fighting in Hue.", Image = "1269f10b-aa48-4e93-b666-76ca1d34fa06_Full Metal Jacket.jpg" },
                    new Movie { Id = 2, DirectorId = 1, Name = "The Shining", Year = 1980, Description = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future", Image = "6c472c63-5322-4081-b558-1ea594fca0d0_The Shining.jpg" },
                    new Movie { Id = 3, DirectorId = 2, Name = "The Pianist", Year = 2002, Description = "A Polish Jewish musician struggles to survive the destruction of the Warsaw ghetto of World War II", Image = "d116b47d-4705-4f88-bb48-409714ec7c58_The Pianist.jpg" },
                    new Movie { Id = 4, DirectorId = 2, Name = "An Offices and Spy", Year = 2019, Description = "In 1894, French Captain Alfred Dreyfus is wrongfully convicted of treason and sentenced to life imprisonment at Devil's island", Image = "d61f21ba-57eb-49d8-bb88-3c3500af5f75_An Officer and Spy.jpg" },
                    new Movie { Id = 5, DirectorId = 3, Name = "Once Upon a Time in Hollywood", Year = 2019, Description = "A faded television actor and his stunt double strive to achieve fame and success in the final years of Hollywood's Golden Age in 1969 Los Angeles", Image = "a501a3f6-530d-4cb1-b7f2-26bd1eb8ac6b_Once Upon a Time in Hollywood.jpg" },
                    new Movie { Id = 6, DirectorId = 3, Name = "Kill Bill Volume 1", Year = 2003, Description = "After awakening from a four-year coma, a former assassin wreaks vengeance on the team of assassins who betrayed her.", Image = "1786becb-0d95-4eab-b103-14e1164e4dfa_Kill Bill Volume 1.jpg" },
                    new Movie { Id = 7, DirectorId = 4, Name = "The Matinee Idol", Year = 1928, Description = "A Broadway matinee idol famous for his black-face portrayals anonymously joins an amateur acting troupe and falls in love with the leading lady", Image = "13d01d4f-6249-4861-bed5-51aa43b6302a_The Matinee Idol.jpg" },
                    new Movie { Id = 8, DirectorId = 4, Name = "The Power Of The Press", Year = 1928, Description = "Naive newspaper cub Clem lands a scoop when he's sent out to cover a murder. In his enthusiasm he writes that the main suspect is Jane. When she confronts Clem she convinces him to help her prove her innocence", Image = "2d97dc9f-3047-4460-9895-d122e671690c_Power_of_the_pressmp.jpg" },
                    new Movie { Id = 9, DirectorId = 5, Name = "The Curios Case of Benjamin Button", Year = 2008, Description = "Tells the story of Benjamin Button, a man who starts aging backwards with consequences", Image = "73297031-ae64-4231-9bac-51e834a0fe04_The Curios Case of Benjamin Button.jpg" },
                    new Movie { Id = 10, DirectorId = 5, Name = "The Social Network", Year = 2010, Description = "As Harvard student Mark Zuckerberg creates the social networking site that would become known as Facebook, he is sued by the twins who claimed he stole their idea and by the co-founder who was later squeezed out of the business", Image = "a919191b-0917-4b7c-9c69-a9f8cb0ae5ff_The_Social_Network_film_poster.png" }

                );
        }
    }
}
