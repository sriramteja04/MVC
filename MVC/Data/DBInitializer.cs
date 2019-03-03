using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Data
{
    public class DBInitializer
    {
        public static void SeedDb(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree alreay exits");

            }
            else
            {
                var degrees = new Models.Degree[]
                {
                    new Models.Degree{DegreeID=1,DegreeAbrrev="ACS+2",DegreeName ="MS ACS +2"},
                     new Models.Degree{DegreeID=2,DegreeAbrrev="ACS+DB",DegreeName ="MS ACS +DB"},
                      new Models.Degree{DegreeID=3,DegreeAbrrev="ACS+NF",DegreeName ="MS ACS+NF"},
                       new Models.Degree{DegreeID=4,DegreeAbrrev="ACS",DegreeName ="MS ACS"}


                };
                Console.WriteLine($"Inserted {degrees.Length} new degrees");

                foreach (Models.Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();

            }

            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirements already exist");
            }
            else
            {
                var requirements = new Models.Requirement[]
                {
                    new Models.Requirement {RequirementID=460,RequirementAbbrev ="DB",RequirementName ="44-460 Database"},
new Models.Requirement {RequirementID=356,RequirementAbbrev ="NF",RequirementName="44-356 Network Fundamemtals"},
new Models.Requirement {RequirementID=542,RequirementAbbrev="OOP",RequirementName="44-542 OOP with Java"},
new Models.Requirement {RequirementID=563,RequirementAbbrev="Web apps",RequirementName="44-563 Web apps"},
new Models.Requirement {RequirementID=560,RequirementAbbrev="ADB",RequirementName="44-560 ADB"},
new Models.Requirement {RequirementID=555,RequirementAbbrev="NS",RequirementName="44-555 Network Security"},
new Models.Requirement {RequirementID=618,RequirementAbbrev="PM",RequirementName="44-618 PM"},



                };
                Console.WriteLine($"Inserted {requirements.Length} new Requirements");

                foreach (Models.Requirement r in requirements)
                {
                    context.Requirements.Add(r);
                }
                context.SaveChanges();

            }

            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("DegreePlanTermRequirements already exist");
            }
            else
            {
                var degreePlanTermRequirements = new Models.DegreePlanTermRequirement[]
                {
                    new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=1,DegreePlanID=20,TermID=1,RequirementID=460},
                    new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=2,DegreePlanID=20,TermID=1,RequirementID=356}


                };
                Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new DegreePlanTermRequirement");

                foreach (Models.DegreePlanTermRequirement dp in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(dp);
                }
                context.SaveChanges();

            }
        }
    }
}

