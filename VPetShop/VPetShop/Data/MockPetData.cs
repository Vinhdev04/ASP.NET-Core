using VPetShop.Models;

namespace VPetShop.Data
{
    public class MockPetData
    {
        public static List<Category> GetCategories()
        {
            return new List<Category>
            {
                new Category { Id = 1, Name = "Chó" },
                new Category { Id = 2, Name = "Mèo" }
            };
        }

        public static List<Pet> GetPets()
        {
            return new List<Pet>
            {
                // Dogs
                new Pet
                {
                    Id = 1,
                    Name = "Chó Poodle Trắng",
                    NewPrice = 100,
                    OldPrice = 120,
                    Description = "Poodle nhỏ nhắn, lông xoăn mềm mại, dễ huấn luyện, lý tưởng cho gia đình.",
                    ImagePath = "/images/poodle-01.jpg",
                    CategoryId = 1,
                    Details = new PetDetails
                    {
                        Origin = "Pháp",
                        Weight = "4-6 kg",
                        Temperament = "Thông minh, thân thiện",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 2,
                    Name = "Chó Poodle Vàng",
                    NewPrice = 150,
                    OldPrice = 180,
                    Description = "Poodle năng động, lông vàng bóng, thích hợp làm bạn đồng hành.",
                    ImagePath = "/images/poodle-02.jpg",
                    CategoryId = 1,
                    Details = new PetDetails
                    {
                        Origin = "Pháp",
                        Weight = "4-6 kg",
                        Temperament = "Năng động, vui vẻ",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 3,
                    Name = "Chó Alaska",
                    NewPrice = 100,
                    OldPrice = 120,
                    Description = "Alaska mạnh mẽ, lông dày, thích hợp cho không gian rộng rãi.",
                    ImagePath = "/images/alaska.jfif",
                    CategoryId = 1,
                    Details = new PetDetails
                    {
                        Origin = "Alaska, Mỹ",
                        Weight = "35-60 kg",
                        Temperament = "Mạnh mẽ, trung thành",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 4,
                    Name = "Chó Husky",
                    NewPrice = 300,
                    OldPrice = 360,
                    Description = "Husky thông minh, lông xù, rất trung thành với chủ.",
                    ImagePath = "/images/husky.jpg",
                    CategoryId = 1,
                    Details = new PetDetails
                    {
                        Origin = "Siberia",
                        Weight = "20-27 kg",
                        Temperament = "Thông minh, trung thành",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 5,
                    Name = "Chó Golden",
                    NewPrice = 200,
                    OldPrice = 240,
                    Description = "Golden thân thiện, lông vàng óng, phù hợp với trẻ em.",
                    ImagePath = "/images/golden.jpg",
                    CategoryId = 1,
                    Details = new PetDetails
                    {
                        Origin = "Anh",
                        Weight = "25-34 kg",
                        Temperament = "Thân thiện, hiền lành",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 6,
                    Name = "Chó Shiba",
                    NewPrice = 200,
                    OldPrice = 240,
                    Description = "Shiba nhanh nhẹn, lông ngắn, tính cách độc lập.",
                    ImagePath = "/images/shiba.jpg",
                    CategoryId = 1,
                    Details = new PetDetails
                    {
                        Origin = "Nhật Bản",
                        Weight = "8-10 kg",
                        Temperament = "Nhanh nhẹn, độc lập",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                // Cats
                new Pet
                {
                    Id = 7,
                    Name = "Mèo Ba Tư",
                    NewPrice = 200,
                    OldPrice = 240,
                    Description = "Mèo Ba Tư lông dài, dịu dàng, thích hợp cho gia đình yêu thích sự nhẹ nhàng.",
                    ImagePath = "/images/Meobatu.jpg",
                    CategoryId = 2,
                    Details = new PetDetails
                    {
                        Origin = "Iran",
                        Weight = "3-5 kg",
                        Temperament = "Dịu dàng, yên tĩnh",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 8,
                    Name = "Mèo Xiêm",
                    NewPrice = 150,
                    OldPrice = 180,
                    Description = "Mèo Xiêm thanh lịch, năng động, thích giao tiếp với chủ.",
                    ImagePath = "/images/siamese.jpg",
                    CategoryId = 2,
                    Details = new PetDetails
                    {
                        Origin = "Thái Lan",
                        Weight = "3-5 kg",
                        Temperament = "Năng động, giao tiếp",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 9,
                    Name = "Mèo Maine Coon",
                    NewPrice = 300,
                    OldPrice = 360,
                    Description = "Maine Coon to lớn, thân thiện, lý tưởng cho không gian rộng.",
                    ImagePath = "/images/mainecoon.jpg",
                    CategoryId = 2,
                    Details = new PetDetails
                    {
                        Origin = "Mỹ",
                        Weight = "5-8 kg",
                        Temperament = "Thân thiện, hiền lành",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 10,
                    Name = "Mèo Ragdoll",
                    NewPrice = 250,
                    OldPrice = 300,
                    Description = "Ragdoll hiền lành, lông mềm, rất thích được ôm ấp.",
                    ImagePath = "/images/ragdoll.jpg",
                    CategoryId = 2,
                    Details = new PetDetails
                    {
                        Origin = "Mỹ",
                        Weight = "4-7 kg",
                        Temperament = "Hiền lành, thích ôm ấp",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 11,
                    Name = "Mèo Sphynx",
                    NewPrice = 400,
                    OldPrice = 480,
                    Description = "Sphynx không lông, độc đáo, thích hợp với người yêu sự khác biệt.",
                    ImagePath = "/images/sphynx.jpg",
                    CategoryId = 2,
                    Details = new PetDetails
                    {
                        Origin = "Canada",
                        Weight = "3-5 kg",
                        Temperament = "Độc đáo, thân thiện",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                },
                new Pet
                {
                    Id = 12,
                    Name = "Mèo Anh Lông Ngắn",
                    NewPrice = 200,
                    OldPrice = 240,
                    Description = "Anh Lông Ngắn tròn trịa, lông mịn, tính cách điềm tĩnh.",
                    ImagePath = "/images/britishshorthair.jpg",
                    CategoryId = 2,
                    Details = new PetDetails
                    {
                        Origin = "Anh",
                        Weight = "4-6 kg",
                        Temperament = "Điềm tĩnh, thân thiện",
                        Health = "Đã tiêm phòng đầy đủ"
                    }
                }
            };
        }
    }
}
