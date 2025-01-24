
// Enum in Java
// An enum (short for "enumeration") is a special class used to define collections of constants.
// It is a type-safe way of representing a fixed set of related constants, making the code more readable and maintainable.
enum Gender {Male,Female};
enum Courses {DataBase,Programming,Math,ERF};
enum Semester {Summer,Winter,Fall,Spring};

// Benefits of using Enum:
// 1. Type Safety: Enums help avoid errors by providing a predefined set of constants. It prevents the usage of invalid values.
// 2. Readability: Enums make code more readable by representing well-known sets of constants (like days of the week, months, etc.).
// 3. Code Maintainability: Enums are easy to maintain since all constants are defined in one place.
// 4. No Magic Numbers: Using enums avoids the use of arbitrary values (like integers or strings) for constant values.

public class RegisterForm
{
    String Stdname;
    Gender StdGender;
    Courses Crs;
    Semester Sem;

    RegisterForm()
    {
        Stdname = "No Name";
        StdGender = Gender.Male;
        Crs = Courses.Math;
        Sem = Semester.Spring;
    }
}
