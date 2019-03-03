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
                new Models.Requirement {RequirementID=1,RequirementAbbrev="Mobile",RequirementName="44-643 or 44-644"},
                new Models.Requirement {RequirementID=664,RequirementAbbrev="UX",RequirementName="44-664 UX"},
                new Models.Requirement {RequirementID=10,RequirementAbbrev="E1",RequirementName="Elective 1"},
                new Models.Requirement {RequirementID=20,RequirementAbbrev="E2",RequirementName="Elective 2"},
                new Models.Requirement {RequirementID=691,RequirementAbbrev="GDP1",RequirementName="GDP1"},
                new Models.Requirement {RequirementID=692,RequirementAbbrev="GDP2",RequirementName="GDP2"},



                };
                Console.WriteLine($"Inserted {requirements.Length} new Requirements");

                foreach (Models.Requirement r in requirements)
                {
                    context.Requirements.Add(r);
                }
                context.SaveChanges();

            }

            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("DegreeRequirements already exist");
            }
            else
            {
                var degreeRequirements = new Models.DegreeRequirement[]
                {

                new Models.DegreeRequirement {DegreeRequirementID=1,DegreeID=1,RequirementID=460},
                new Models.DegreeRequirement {DegreeRequirementID=2,DegreeID=1,RequirementID=356},
                new Models.DegreeRequirement {DegreeRequirementID=3,DegreeID=1,RequirementID=542},
                new Models.DegreeRequirement {DegreeRequirementID=4,DegreeID=1,RequirementID=563},
                new Models.DegreeRequirement {DegreeRequirementID=5,DegreeID=1,RequirementID=560},
                new Models.DegreeRequirement {DegreeRequirementID=6,DegreeID=1,RequirementID=555},
                new Models.DegreeRequirement {DegreeRequirementID=7,DegreeID=1,RequirementID=618},
                new Models.DegreeRequirement {DegreeRequirementID=8,DegreeID=1,RequirementID=1},
                new Models.DegreeRequirement {DegreeRequirementID=9,DegreeID=1,RequirementID=664},
                new Models.DegreeRequirement {DegreeRequirementID=10,DegreeID=1,RequirementID=10},
                new Models.DegreeRequirement {DegreeRequirementID=11,DegreeID=1,RequirementID=20},
                new Models.DegreeRequirement {DegreeRequirementID=12,DegreeID=1,RequirementID=691},
                new Models.DegreeRequirement {DegreeRequirementID=13,DegreeID=1,RequirementID=692},
                new Models.DegreeRequirement {DegreeRequirementID=14,DegreeID=2,RequirementID=460},
                new Models.DegreeRequirement {DegreeRequirementID=15,DegreeID=2,RequirementID=542},
                new Models.DegreeRequirement {DegreeRequirementID=16,DegreeID=2,RequirementID=563},
                new Models.DegreeRequirement {DegreeRequirementID=17,DegreeID=2,RequirementID=560},
                new Models.DegreeRequirement {DegreeRequirementID=18,DegreeID=2,RequirementID=555},
                new Models.DegreeRequirement {DegreeRequirementID=19,DegreeID=2,RequirementID=618},
                new Models.DegreeRequirement {DegreeRequirementID=20,DegreeID=2,RequirementID=1},
                new Models.DegreeRequirement {DegreeRequirementID=21,DegreeID=2,RequirementID=664},
                new Models.DegreeRequirement {DegreeRequirementID=22,DegreeID=2,RequirementID=10},
                new Models.DegreeRequirement {DegreeRequirementID=23,DegreeID=2,RequirementID=20},
                new Models.DegreeRequirement {DegreeRequirementID=24,DegreeID=2,RequirementID=691},
                new Models.DegreeRequirement {DegreeRequirementID=25,DegreeID=2,RequirementID=692},
                new Models.DegreeRequirement {DegreeRequirementID=26,DegreeID=3,RequirementID=356},
                new Models.DegreeRequirement {DegreeRequirementID=27,DegreeID=3,RequirementID=542},
                new Models.DegreeRequirement {DegreeRequirementID=28,DegreeID=3,RequirementID=563},
                new Models.DegreeRequirement {DegreeRequirementID=29,DegreeID=3,RequirementID=560},
                new Models.DegreeRequirement {DegreeRequirementID=30,DegreeID=3,RequirementID=555},
                new Models.DegreeRequirement {DegreeRequirementID=31,DegreeID=3,RequirementID=618},
                new Models.DegreeRequirement {DegreeRequirementID=32,DegreeID=3,RequirementID=1},
                new Models.DegreeRequirement {DegreeRequirementID=33,DegreeID=3,RequirementID=664},
                new Models.DegreeRequirement {DegreeRequirementID=34,DegreeID=3,RequirementID=10},
                new Models.DegreeRequirement {DegreeRequirementID=35,DegreeID=3,RequirementID=20},
                new Models.DegreeRequirement {DegreeRequirementID=36,DegreeID=3,RequirementID=691},
                new Models.DegreeRequirement {DegreeRequirementID=37,DegreeID=3,RequirementID=692},
                new Models.DegreeRequirement {DegreeRequirementID=38,DegreeID=4,RequirementID=542},
                new Models.DegreeRequirement {DegreeRequirementID=39,DegreeID=4,RequirementID=563},
                new Models.DegreeRequirement {DegreeRequirementID=40,DegreeID=4,RequirementID=560},
                new Models.DegreeRequirement {DegreeRequirementID=41,DegreeID=4,RequirementID=555},
                new Models.DegreeRequirement {DegreeRequirementID=42,DegreeID=4,RequirementID=618},
                new Models.DegreeRequirement {DegreeRequirementID=43,DegreeID=4,RequirementID=1},
                new Models.DegreeRequirement {DegreeRequirementID=44,DegreeID=4,RequirementID=664},
                new Models.DegreeRequirement {DegreeRequirementID=45,DegreeID=4,RequirementID=10},
                new Models.DegreeRequirement {DegreeRequirementID=46,DegreeID=4,RequirementID=20},
                new Models.DegreeRequirement {DegreeRequirementID=47,DegreeID=4,RequirementID=691},
                new Models.DegreeRequirement {DegreeRequirementID=48,DegreeID=4,RequirementID=692},


                };
                Console.WriteLine($"Inserted {degreeRequirements.Length} new DegreeRequirement");

                foreach (Models.DegreeRequirement dr in degreeRequirements)
                {
                    context.DegreeRequirements.Add(dr);
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
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=1,DegreePlanID=10,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=2,DegreePlanID=10,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=3,DegreePlanID=10,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=4,DegreePlanID=10,TermID=2,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=5,DegreePlanID=10,TermID=2,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=6,DegreePlanID=10,TermID=3,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=7,DegreePlanID=10,TermID=3,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=8,DegreePlanID=10,TermID=3,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=9,DegreePlanID=10,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=10,DegreePlanID=10,TermID=4,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=11,DegreePlanID=10,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=12,DegreePlanID=11,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=13,DegreePlanID=11,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=14,DegreePlanID=11,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=15,DegreePlanID=11,TermID=2,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=16,DegreePlanID=11,TermID=2,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=17,DegreePlanID=11,TermID=2,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=18,DegreePlanID=11,TermID=4,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=19,DegreePlanID=11,TermID=4,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=20,DegreePlanID=11,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=21,DegreePlanID=11,TermID=5,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=22,DegreePlanID=11,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=23,DegreePlanID=12,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=24,DegreePlanID=12,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=25,DegreePlanID=12,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=26,DegreePlanID=12,TermID=2,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=27,DegreePlanID=12,TermID=2,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=28,DegreePlanID=12,TermID=3,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=29,DegreePlanID=12,TermID=3,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=30,DegreePlanID=12,TermID=3,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=31,DegreePlanID=12,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=32,DegreePlanID=12,TermID=4,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=33,DegreePlanID=12,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=34,DegreePlanID=13,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=35,DegreePlanID=13,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=36,DegreePlanID=13,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=37,DegreePlanID=13,TermID=3,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=38,DegreePlanID=13,TermID=3,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=39,DegreePlanID=13,TermID=3,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=40,DegreePlanID=13,TermID=4,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=41,DegreePlanID=13,TermID=4,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=42,DegreePlanID=13,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=43,DegreePlanID=13,TermID=5,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=44,DegreePlanID=13,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=45,DegreePlanID=14,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=46,DegreePlanID=14,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=47,DegreePlanID=14,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=48,DegreePlanID=14,TermID=2,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=49,DegreePlanID=14,TermID=2,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=50,DegreePlanID=14,TermID=3,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=51,DegreePlanID=14,TermID=3,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=52,DegreePlanID=14,TermID=3,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=53,DegreePlanID=14,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=54,DegreePlanID=14,TermID=4,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=55,DegreePlanID=14,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=56,DegreePlanID=15,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=57,DegreePlanID=15,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=58,DegreePlanID=15,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=59,DegreePlanID=15,TermID=2,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=60,DegreePlanID=15,TermID=2,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=61,DegreePlanID=15,TermID=2,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=62,DegreePlanID=15,TermID=4,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=63,DegreePlanID=15,TermID=4,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=64,DegreePlanID=15,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=65,DegreePlanID=15,TermID=5,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=66,DegreePlanID=15,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=67,DegreePlanID=16,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=68,DegreePlanID=16,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=69,DegreePlanID=16,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=70,DegreePlanID=16,TermID=2,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=71,DegreePlanID=16,TermID=2,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=72,DegreePlanID=16,TermID=3,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=73,DegreePlanID=16,TermID=3,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=74,DegreePlanID=16,TermID=4,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=75,DegreePlanID=16,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=76,DegreePlanID=16,TermID=4,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=77,DegreePlanID=16,TermID=5,RequirementID=692},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=78,DegreePlanID=17,TermID=1,RequirementID=560},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=79,DegreePlanID=17,TermID=1,RequirementID=542},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=80,DegreePlanID=17,TermID=1,RequirementID=563},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=81,DegreePlanID=17,TermID=3,RequirementID=555},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=82,DegreePlanID=17,TermID=3,RequirementID=618},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=83,DegreePlanID=17,TermID=3,RequirementID=1},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=84,DegreePlanID=17,TermID=4,RequirementID=664},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=85,DegreePlanID=17,TermID=4,RequirementID=691},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=86,DegreePlanID=17,TermID=4,RequirementID=10},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=87,DegreePlanID=17,TermID=5,RequirementID=20},
                    new Models.DegreePlanTermRequirement{DegreePlanTermRequirementID=88,DegreePlanID=17,TermID=5,RequirementID=692},

                };
                Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new DegreePlanTermRequirement");

                foreach (Models.DegreePlanTermRequirement dp in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(dp);
                }
                context.SaveChanges();

            }

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("DegreePlans already exist");
            }
            else
            {
                var degreePlans = new Models.DegreePlan[]
                {
                new Models.DegreePlan{DegreePlanID=10,DegreeID=4,StudentID=531441,DegreePlanAbbrev="No summer off",DegreePlanName="As Fast as I Can"},
                new Models.DegreePlan{DegreePlanID=11,DegreeID=4,StudentID=531441,DegreePlanAbbrev="Summer Off",DegreePlanName="Slow and Easy"},
                new Models.DegreePlan{DegreePlanID=12,DegreeID=4,StudentID=531524,DegreePlanAbbrev="No summer off",DegreePlanName="As Fast as I Can"},
                new Models.DegreePlan{DegreePlanID=13,DegreeID=4,StudentID=531524,DegreePlanAbbrev="Summer Off",DegreePlanName="Slow and Easy"},
                new Models.DegreePlan{DegreePlanID=14,DegreeID=4,StudentID=531506,DegreePlanAbbrev="No summer off",DegreePlanName="As Fast as I Can"},
                new Models.DegreePlan{DegreePlanID=15,DegreeID=4,StudentID=531506,DegreePlanAbbrev="Summer Off",DegreePlanName="Slow and Easy"},
                new Models.DegreePlan{DegreePlanID=16,DegreeID=4,StudentID=530469,DegreePlanAbbrev="No summer off",DegreePlanName="As Fast as I Can"},
                new Models.DegreePlan{DegreePlanID=17,DegreeID=4,StudentID=530469,DegreePlanAbbrev="Summer Off",DegreePlanName="Slow and Easy"},




                };
                Console.WriteLine($"Inserted {degreePlans.Length} new Requirements");

                foreach (Models.DegreePlan dp in degreePlans)
                {
                    context.DegreePlans.Add(dp);
                }
                context.SaveChanges();

            }

            if (context.Students.Any())
            {
                Console.WriteLine("Students already exist");
            }
            else
            {
                var students = new Models.Student[]
                {
                       new Models.Student{StudentID=531441,First="Vyshnavi srilaxmi",Last="Thannir",Snumber="531441",SID=919562404},
                        new Models.Student{StudentID=531524,First="Sri Ram Teja",Last="Komerisetti",Snumber="531524",SID=919562444},
                        new Models.Student{StudentID=530469,First="Chandra Mouli",Last="Kantipudi",Snumber="530469",SID=919559547},
                        new Models.Student{StudentID=531506,First="Prashanth Kumar",Last="Thallada",Snumber="531506",SID=919562179},




                };
                Console.WriteLine($"Inserted {students.Length} new Students");

                foreach (Models.Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();

            }

            if (context.StudentTerms.Any())
            {
                Console.WriteLine("StudentTerms already exist");
            }
            else
            {
                var studentTerms = new Models.StudentTerm[]
                {
                        new Models.StudentTerm{StudentTermID=1,StudentID="531441",TermID=1,TermLabel="Fall 2017"},
                        new Models.StudentTerm{StudentTermID=2,StudentID="531441",TermID=2,TermLabel="Spring 2018"},
                        new Models.StudentTerm{StudentTermID=3,StudentID="531441",TermID=3,TermLabel="Summer 2018"},
                        new Models.StudentTerm{StudentTermID=4,StudentID="531441",TermID=4,TermLabel="Fall 2018"},
                        new Models.StudentTerm{StudentTermID=5,StudentID="531441",TermID=5,TermLabel="Spring 2019"},
                        new Models.StudentTerm{StudentTermID=6,StudentID="531524",TermID=1,TermLabel="Spring 2018"},
                        new Models.StudentTerm{StudentTermID=7,StudentID="531524",TermID=2,TermLabel="Summer 2018"},
                        new Models.StudentTerm{StudentTermID=8,StudentID="531524",TermID=3,TermLabel="Fall 2018"},
                        new Models.StudentTerm{StudentTermID=9,StudentID="531524",TermID=4,TermLabel="Spring 2019"},
                        new Models.StudentTerm{StudentTermID=10,StudentID="531524",TermID=5,TermLabel="Summer 2019"},
                        new Models.StudentTerm{StudentTermID=11,StudentID="530469",TermID=1,TermLabel="Fall 2018"},
                        new Models.StudentTerm{StudentTermID=12,StudentID="530469",TermID=2,TermLabel="Spring 2019"},
                        new Models.StudentTerm{StudentTermID=13,StudentID="530469",TermID=3,TermLabel="Summer 2019"},
                        new Models.StudentTerm{StudentTermID=14,StudentID="530469",TermID=4,TermLabel="Fall 2019"},
                        new Models.StudentTerm{StudentTermID=15,StudentID="530469",TermID=5,TermLabel="Spring 2020"},
                        new Models.StudentTerm{StudentTermID=16,StudentID="531506",TermID=1,TermLabel="Spring 2020"},
                        new Models.StudentTerm{StudentTermID=17,StudentID="531506",TermID=2,TermLabel="Summer 2020"},
                        new Models.StudentTerm{StudentTermID=18,StudentID="531506",TermID=3,TermLabel="Fall 2020"},
                        new Models.StudentTerm{StudentTermID=19,StudentID="531506",TermID=4,TermLabel="Spring 2021"},
                        new Models.StudentTerm{StudentTermID=20,StudentID="531506",TermID=5,TermLabel='Summer 2021"},




                };
                Console.WriteLine($"Inserted {studentTerms.Length} new studentTerms");

                foreach (Models.Student st in studentTerms)
                {
                    context.StudentTerms.Add(st);
                }
                context.SaveChanges();

            }
        }
    }
}

