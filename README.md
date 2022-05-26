# JobTestApp
Yo, hi to those gentelmen and ladies who will review this code.
First of all, thank you for this test, secondly, fck it, I've benn thinking 'bout this task for a long time, but, eventually, I think I did it :)

-----------------------------------------
Ok, let's go.

Firstly, "create web api, asp core, ef code first (edited)
Introduce the API to create the following records: contacts, accounts, incidents (edited)
logic for incident creation method"

I created a model for this task called UserCreation.cs

U wanted me to create a "logic for incident creation method"))))
public string IncidentName { get; set; } = Guid.NewGuid().ToString();
Well, I assigned a GUID generator to IncidentName. Why? Is it safe? Can those pseudo "random" numbers and letters repeat?
I were asking myself those questions during development.
1) There are 2^128 possible combinations for GUID. And a format is 8-4-4-4-12 chunks. Pretty cool isn't it?
Yes, those numbers can repeat BUT percentage of it is very low(It's for a test job, it does its work) :)

-----------------------------------------
"account cannot be created without contact
incident cannot be created without account"

For this thing I created POST method in UserCreationController.cs, like POSTing ONLY NEW users in the system.

"Validation
if account name is not in the system -> API must return 404 – NotFound
if contact is in the system (check by email) -> update contact record, link contact to account if it has not been linked prevoisly.
Otherwise,
create new contact with first name, last name, email and
link just created contact to the account
create new incident, for account and populate incident description field"

And for this "creature of validation" I created PUT method in the same UserCreationController.cs for users that are ALREADY in the system.

-----------------------------------------
Well, I wanna thank you for this test task, tbhwy, it took me 2 days to make it done. Hope it was not difficult to read these lines of code.
What to do if u find a bug? Fix it pls, or point it to me, I'll try to fix it.
With love from little programmer who wants to work. I wanna sleep, bye.

-----------------------------------------
Stil have questions 'bout this code? @DreadToki <- telegram, I'll answer u
❤️❤️❤️❤️
