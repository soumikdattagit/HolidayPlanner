# Holiday Planner (.Net 6.0)

This application calculates consumed holidays for an employee based on a Start Date & End Date.


## My understanding of the problem

- End date must be after the Start date.
- Maximum period of time span between the Start & End dates should not be more than `50` days.
- Both of these dates must be on the same holiday calendar year. For ex: 1.12.2023 - 2.1.2024 is a valid span, while 1.3.2023 - 1.4.2023 is not.
- Public holidays do not consume holidays of employee.
- Sundays do not consume holidays of employee.
- Saturdays consumes holidays of employee.


## Implementation challenges

The solution was not much complicated. Still, I would like to mention out the below point.

- Separating logics in different folders based on functionality (ex: business logic & validation logics separation). This is not super complicated but given the time constraint it was little thoughtful.


## Assumptions

- Hard coded Start date & End date in the program.cs. Can be changed easily before running the app.
- Since, the holiday list was there for 2023 & 2024, I assumed Start date cannot be before `01.01.2023` & End date cannot be after `31.12.2024`.
- I have created a Countries.cs file and inside kept "`Finland`" as key value pair. In future other countries can be added here. Based on this we can map to country specific public holiday list and initialize it.
- I spent about 3 hours completing the task & tried my best to write methods in a such ways that unit testing could be easy.


## Improvement areas

Although the solution works as per the requirements & there are few additional validations as well in place, this application can be further improved by below points which I was unable to do within the the short period of time.

- The list of public holidays for Finland is now stored in a list variable of DateOnly type (Models > `PublicHolidaysFinland.cs`). In future if this application is used by other countries, it's easy to set up a separate country specific holidays in another list.
- Right now, the other countries holiday lists could be initialized through `GetPublicHolidaysByCountry()` method inside `Planner.cs`. Although, this solution is ok for now, best way to achieve this is through `FACTORY` pattern to make the application more `losely coupled`.
- Validation is done through a common `Validators.cs` class now, which should be improved further by using country specific validation rules.
- Same goes for Constants > `HolidayRules.cs` & `Messages.cs`.
- I spent about 3 hours completing the task & tried my best to design the methods in a such ways that unit testing could be easy. Did not write unit test cases due to time constraints.
- Country code `("1" - for FINLAND)` is right now used in the Program.cs > `ProcessHolidays()`, this can be taken as an input from the user to make the system dynamic to support other countries.




# Thank You!

Thank you so much for your patience on reading this. Hope this helps understanding the application. If you still have some doubts, please reach out to me at `soumikdatta09@gmail.com`.
