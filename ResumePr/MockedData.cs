namespace ResumePr
{
    public static class MockedData
    {
        public static Resume[] GetMockedResumes()
        {
            return new Resume[]
            {
                new Resume
                {
                    id = 1,
                    PersonalInformation = new PersonalInformation
                    {
                        FirstName = "Ion",
                        LastName = "Popescu",
                        Email = "ion.popescu@example.com",
                        PhoneNumber = "123456789",
                        NumberPrefix = "+40",
                        SocialProfiles = new string[] { "https://facebook.com/ion.popescu", "https://linkedin.com/in/ion.popescu" },
                        PersonalDescription = "I am a passionate software engineer with experience in building web applications using .NET Core. I take pride in my work and always strive to learn and adapt in the rapidly changing tech world."

                    },
                    ProfessionalInformation = new ProfessionalInformation
                    {
                        Experiences = new Experience[]
                        {
                            new Experience
                            {
                                JobTitle = "Software Engineer",
                                CompanyName = "ABC Tech",
                                EmploymentStartDate = new DateTime(2020, 1, 1),
                                EmploymentEndDate = null,
                                IsCurrentEmployer = true,
                                Location = "Bucharest, Romania",
                                JobDescription = "Developing web applications using .NET Core."
                            },
                            new Experience
                            {
                                JobTitle = "Intern",
                                CompanyName = "XYZ Innovations",
                                EmploymentStartDate = new DateTime(2019, 6, 1),
                                EmploymentEndDate = new DateTime(2019, 9, 1),
                                IsCurrentEmployer = false,
                                Location = "Cluj-Napoca, Romania",
                                JobDescription = "Worked on automating internal processes."
                            }
                        },
                        Educations = new Education[]
                        {
                            new Education
                            {
                                InstitutionTitle = "University of Bucharest",
                                StartDate = new DateTime(2016, 10, 1),
                                EndDate = new DateTime(2019, 7, 1),
                                IsCurrent = false,
                                DegreeTitle = "BS Computer Science",
                                Description = "Studied fundamental and advanced topics in computer science."
                            }
                        },
                        Skills = new string[] { "C#", ".NET Core", "SQL" },
                        Languages = new LanguageProficiency[]
                        {
                            new LanguageProficiency { Language = "Romanian", ProficiencyLevel = "Native" },
                            new LanguageProficiency { Language = "English", ProficiencyLevel = "Advanced" }
                        }
                    }
                },
                new Resume
                {
                    id = 2,
                    PersonalInformation = new PersonalInformation
                    {
                        FirstName = "Ana",
                        LastName = "Ionescu",
                        Email = "ana.ionescu@example.com",
                        PhoneNumber = "987654321",
                        NumberPrefix = "+40",
                        SocialProfiles = new string[] { "https://twitter.com/ana.ionescu", "https://linkedin.com/in/ana.ionescu" },
                        PersonalDescription = "I am a dedicated data scientist with a keen interest in machine learning techniques. I enjoy digging into data, finding patterns, and leveraging those insights to solve real-world problems."

                    },
                    ProfessionalInformation = new ProfessionalInformation
                    {
                        Experiences = new Experience[]
                        {
                            new Experience
                            {
                                JobTitle = "Data Scientist",
                                CompanyName = "DataCorp EU",
                                EmploymentStartDate = new DateTime(2021, 2, 1),
                                EmploymentEndDate = null,
                                IsCurrentEmployer = true,
                                Location = "Brasov, Romania",
                                JobDescription = "Working on machine learning models for predicting user behaviors."
                            }
                        },
                        Educations = new Education[]
                        {
                            new Education
                            {
                                InstitutionTitle = "Polytechnic University of Timisoara",
                                StartDate = new DateTime(2017, 10, 1),
                                EndDate = new DateTime(2020, 7, 1),
                                IsCurrent = false,
                                DegreeTitle = "MS Data Science",
                                Description = "Specialized in advanced data processing and machine learning techniques."
                            }
                        },
                        Skills = new string[] { "Python", "TensorFlow", "R" },
                        Languages = new LanguageProficiency[]
                        {
                            new LanguageProficiency { Language = "Romanian", ProficiencyLevel = "Native" },
                            new LanguageProficiency { Language = "English", ProficiencyLevel = "Intermediate" }
                        }
                    }
                }
            };
        }
    }
}
