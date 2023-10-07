using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumePr
{

    public class Experience
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public DateTime? EmploymentEndDate { get; set; }  // Nullable DateTime to handle cases where the end date might not be known yet
        public bool IsCurrentEmployer { get; set; }
        public string Location { get; set; }
        public string JobDescription { get; set; }

        public override string ToString()
        {
            string endDateDisplay = IsCurrentEmployer ? "Present" : EmploymentEndDate?.ToString("MMMM yyyy");
            return $"{JobTitle} at {CompanyName}, {Location}\n" +
                   $"{EmploymentStartDate:MMMM yyyy} - {endDateDisplay}\n" +
                   $"{JobDescription}\n";
        }
    }

    public class Education
    {
        public string InstitutionTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }  // Nullable DateTime for when the end date might not be known yet
        public bool IsCurrent { get; set; }
        public string DegreeTitle { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            string endDateDisplay = IsCurrent ? "Present" : EndDate?.ToString("MMMM yyyy");
            return $"{DegreeTitle} from {InstitutionTitle}\n" +
                   $"{StartDate:MMMM yyyy} - {endDateDisplay}\n" +
                   $"{Description}\n";
        }
    }


    public class LanguageProficiency
    {
        public string Language { get; set; }
        public string ProficiencyLevel { get; set; }  // e.g., "Beginner", "Intermediate", "Advanced", "Native"

        public override string ToString()
        {
            return $"{Language} ({ProficiencyLevel})";
        }
    }

    public class ProfessionalInformation
    {
        public Experience[] Experiences { get; set; }
        public Education[] Educations { get; set; }
        public string[] Skills { get; set; }
        public LanguageProficiency[] Languages { get; set; }

        public override string ToString()
        {
            return $"\nExperiences: {string.Join("\n", Experiences.Select(e => e.ToString()))}" +
                   $"\nEducation: {string.Join("\n", Educations.Select(e => e.ToString()))}" +
                   $"\nSkills: {string.Join(", ", Skills)}" +
                   $"\nLanguages: {string.Join(", ", Languages.Select(l => l.ToString()))}";
        }

    }



    public class PersonalInformation
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string NumberPrefix { get; set; }
        public string[] SocialProfiles { get; set; }
        public string PersonalDescription { get; set; }

        public override string ToString()
        {
            return $"\nFirst name: {FirstName}" +
                   $"\nLast name: {LastName}"+
                   $"\nEmail: {Email}" +
                   $"\nPhone Number: {NumberPrefix} {PhoneNumber}" +
                   $"\nSocial Profiles: {string.Join(", ", SocialProfiles)}" +
                   $"\nDescription: {PersonalDescription}";  // Added this line

        }


    }


    public class Resume
    {
        public int id { get; set; }
        public PersonalInformation PersonalInformation { get; set; }

        public ProfessionalInformation ProfessionalInformation { get; set;}


        public override string ToString()
        {
            return $"Resume {id} Details:" +
                   $"{PersonalInformation}" +
                   $"{ProfessionalInformation}\n";
        }

    }
}
