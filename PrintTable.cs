namespace GPACalculator
{
    public static class PrintTable
    {
        public static void CalculateGpa()
        {
            Console.WriteLine("How many courses did you offer?");
            int noOfCourses = 0;
            noOfCourses = Convert.ToInt32(Console.ReadLine());

            int[] listOfCourseUnit = new int[noOfCourses];
            int[] courseScore = new int[noOfCourses];
            string[] listOfCourseCode = new string[noOfCourses];
            string[] grade = new string[noOfCourses];
            int[] gradeUnit = new int[noOfCourses];
            double[] weightPt = new double[noOfCourses];
            string[] remarks = new string[noOfCourses];


            for (int i = 0; i < noOfCourses; i++)
            {
                Console.WriteLine("Please enter the course name and code: ");
                string waza = Console.ReadLine();
                listOfCourseCode[i] = Console.ReadLine();

                Console.WriteLine("Enter you course unit: ");
                int x = Convert.ToInt32(Console.ReadLine());
                listOfCourseUnit[i] = x;

                Console.WriteLine(" Please enter your course score: ");
                int y = Convert.ToInt32(Console.ReadLine());
                courseScore[i] = y;


                if (courseScore[i] >= 70 && courseScore[i] <= 100)
                {
                    grade[i] = "A";
                    gradeUnit[i] = 5;
                    remarks[i] = "Excellent";
                }
                else if (courseScore[i] >= 60 && courseScore[i] < 70)
                {
                    grade[i] = "B";
                    gradeUnit[i] = 4;
                    remarks[i] = "Very Good";
                }
                else if (courseScore[i] >= 50 && courseScore[i] < 60)
                {
                    grade[i] = "C";
                    gradeUnit[i] = 3;
                    remarks[i] = "Good";
                }
                else if (courseScore[i] >= 40 && courseScore[i] < 50)
                {
                    grade[i] = "D";
                    gradeUnit[i] = 2;
                    remarks[i] = "Fair";
                }
                else if (courseScore[i] >= 30 && courseScore[i] < 40)
                {
                    grade[i] = "E";
                    gradeUnit[i] = 1;
                    remarks[i] = "Poor";
                }
                else
                {
                    grade[i] = "F";
                    gradeUnit[i] = 0;
                    remarks[i] = "Fail";
                }

                weightPt[i] = listOfCourseUnit[i] * gradeUnit[i];

            }

            int totalCU = 0; int totalGU = 0; double totalWeightPt = 0;
            for (int i = 0; i < noOfCourses; i++)
            {
                totalCU += listOfCourseUnit[i];
                totalGU += gradeUnit[i];
                totalWeightPt += weightPt[i];
            }


            double GPA = totalWeightPt / totalCU;


            Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|------------------|-------------------|");
            Console.WriteLine("| COURSE & CODE              |           COURSE UNIT |      GRADE |          GRADE-UNIT |       WEIGHT Pt. | REMARK");         
            Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|------------------|-------------------|");

            for (int i = 0; i< noOfCourses; i++)
            {
                Console.WriteLine("| {0,26} | {1,21} | {2, 10} | {3, 19} | {4,16} | {5,16}  |", listOfCourseCode[i], listOfCourseUnit[i], grade[i], gradeUnit[i], weightPt[i], remarks[i]);

            }

            Console.WriteLine("|----------------------------|-----------------------|------------|---------------------|------------------|-------------------|");

            Console.WriteLine("Total Course Unit Registered is " + totalCU);
            Console.WriteLine("Total Course Unit Passed is " + totalGU);
            Console.WriteLine("Total Weight Point is " + totalWeightPt);


            Console.WriteLine("Your GPA is = " + GPA.ToString("0.##"));
        }
    }
}