#region Comments

//  Inline comment - only spans the one line

/*  Block comment(ctrl + shift + *)
 *      Can span multiple lines
*/

/// <summary>
/// Summary comment for methods, to show information about its arguments in IntelliSense
/// </summary>

#endregion

#region Data Types

/*
 * FRONTEND (REACT JS) - BACKEND API (C#) - DATABASE (SQL)
 * 
 * JS               C#                                                      SQL
 * -------------------------------------------------------------------------------------------------------------------------
 * Number           sbyte, byte, ushort, int, uint, long, ulong,            bit, tinyint, smallint, int, bigint, decimal,
 *                  Int16, Int32, Int64, decimal, double, float             float, real, smallmoney, money, numeric
 * 
 * String           char, string                                            char, varchar, text, nchar, nvarchar, ntext
 * Boolean          bool                                                    bit
 * Object           object                                                  ---
 * null (Object)    null                                                    null
 * Undefined        null                                                    null
 * ---              dynamic                                                 ---
 * ---              custom                                                  ---
 * ---              Guid (Global Unique Identifier)                         uniqueidentifier
 * 
 * 
 * C# Integrals - någon form av nummer
 * TYPE             BIT             MIN VALUE                          MAX VALUE
 * -------------------------------------------------------------------------------------------------------------------------
 * sbyte            8               -128                            127
 * byte             8               0                               255
 * short            16              -32,768                         32,767
 * ushort           16              0                               65,535
 * int              32              -2,147,483,648                  2,147,485,647
 * uint             32              0                               4,292,967,295
 * long             64              -9,223,372,036,854,775,808      9,223,372,036,854,775,807
 * ulong            64              0                               18,446,744,073,709,551,615
 * 
 * Int16            16              same as short
 * Int32            32              same as int
 * Int64            64              same as long
 * 
 * 
 * C# Floating Points
 * TYPE             BYTES       DECIMAL RANGE           SUFFIX          USED FOR
 * -------------------------------------------------------------------------------------------------------------------------
 * float            4           6-9 digits              f or F          Machine Learning
 * double           8           15-16 digits            d or D          Optimizing performance and storage
 * decimal          16          28-28 digits            m or M          Financial numbers like money
 * 
 * double doesn't require a suffix
 * 
 * 
 * C# Strings
 * TYPE             BIT         SCHEME                  CHAR RANGE
 * -------------------------------------------------------------------------------------------------------------------------
 * char             16          ASCII/UTF-8 (unicode)   ASCII (X+0000 -> X+FFFF), UTF-8 (U+0000 -> U+FFFF)
 * string           64          ASCII/UTF-8 (unicode)   max 2GB (~1,000,000,000 tecken)
 * 
 * ASCII = Engelska
 * UTF-8 = Svenska och andra språk (specialtecken som åäö)
 * 
 * char text = '';
 * string text = "";
 * 
 * \ is used to escape the next character and read it as a regular character
 * @ before a string can be used to read the entire string as regular text (essentially escaping every single character)
 *      note: does not work for text that contains quotation marks (such as JSON)
 * $ before a string can be used to insert placeholders using {variableName} directly inside the string
 * @ and $ can be combined for the same string
 * \n creates a new line
 * \t creates a tab
 * 
 * 
 * C# Booleans
 * TYPE             BIT         VALUES
 * -------------------------------------------------------------------------------------------------------------------------
 * bool             1           true/false (0/1)
 * 
 * 
 * C# Guid (Global Unique Identifier)
 * VARIABLE         BYTES       COMMAND                 RESULT
 * -------------------------------------------------------------------------------------------------------------------------
 * Guid id;         16          Guid.NewGuid();         A unique sequence of hexadecimal numbers
 */

#endregion

#region Variables

/*
 * VARIABLE
 * LANGUAGE     MODEL               EXAMPLE             DESCRIPTION
 * -------------------------------------------------------------------------------------------------------------------------
 * C#           Pascal              FirstName           Capital letter at the start of every word
 * JS           camelCase           firstName           Capital letter at the start of every word except the first
 * Java         camelCase
 * C/C++        camelCase
 * Python       snake_case          first_name          Non-capital letters only, underscore between words
 * 
 * 
 * DESIGN PATTERN
 * VARIABLE     EXAMPLE                                             USAGE
 * -------------------------------------------------------------------------------------------------------------------------
 * Field        firstName                                           Inside a class
 * Property     FirstName                                           Inside a class with getters/setters
 * Parameter    firstName                                           Input for a method/function
 * Variable     firstName, FirstName, firstname, _firstName         Inside a method/function
 * 
 * 
 * DECLARING VARIABLES
 * -------------------------------------------------------------------------------------------------------------------------
 * string firstName                         Declaring with a set data type
 * var firstName = "Amanda"                 Declaring with a non-set data type, must immediately give it an initial value
 * dynamic firstName = "Amanda"             Declaring with a dynamic data type, which can be changed over time
 * 
 * 
 * CONVERTING DATA TYPES
 * -------------------------------------------------------------------------------------------------------------------------
 * byte.Parse()
 * int.Parse()
 * bool.Parse()
 * long.Parse()
 */

#endregion

#region Lists & Arrays

/*
 * LIST
 * -------------------------------------------------------------------------------------------------------------------------
 * List<int> numbers            List<int> numbers = new List<int>();
 * List<string> names           var names = new List<string>();
 * List<Customer> customers     List<Customer> customers = new();
 * 
 * 
 * ARRAY (an array is not a list, and has a fixed size)
 * -------------------------------------------------------------------------------------------------------------------------
 * int[] numbers                int[] numbers = new int[5];
 * string[] names               string[] names = new string[] { "Amanda", "Diana" };
 * string[] customers           string[] customers = { "Customer 1", "Customer 2" };
 */

#endregion

#region Loops

/*
 * FOR LOOP - repeats a statement a given number of times
 * -------------------------------------------------------------------------------------------------------------------------
 * for(int i = 0; i <= 10; i++)
 * {
 * }
 * 
 * 
 * FOREACH LOOP - repeats a statement once per item in a list or array
 * -------------------------------------------------------------------------------------------------------------------------
 * for(var item in items)
 * {
 * }
 * 
 * 
 * WHILE LOOP - repeats a statement until the condition is no longer true
 * WARNING! Make sure the statement can actually become false
 * -------------------------------------------------------------------------------------------------------------------------
 * int i = 0;
 * while(i < 10)
 * {
 *      i++;
 * }
 * 
 * 
 * DO WHILE LOOP - repeats a statement at least once and then until the condition is no longer true
 * WARNING! Make sure the statement can actually become false
 * -------------------------------------------------------------------------------------------------------------------------
 * int i = 0;
 * do
 * {
 *      i++;
 * }
 * while(i < 10);
 */

#endregion