//Initialize variables

//Show an introduction message to set the scene and instruct the player what the objective is

//Start the main game screen

/// <summary>
/// The main screen of the game, which shows basic overview information about the event and unread messages.
/// </summary>
void MainScreen()
{
    //Show basic event details (age limit, number of attendees, time left, etc) and notification icon

    //Show a list of available commands

    //Wait for player command
}

/// <summary>
/// A screen that shows all received messages, with unread messages highlighted.
/// </summary>
void MessageListScreen()
{
    //Show basic event details (age limit, number of attendees, time left, etc) and notification icon

    //Show a list of messages, with unread messages highlighted

    //Show a list of available commands

    //Wait for player command
}

/// <summary>
/// A screen that shows the text of a specified message.
/// </summary>
/// <param name="m">The message to show</param>
void MessageScreen(Message m)
{
    //Show basic event details (age limit, number of attendees, time left, etc) and notification icon

    //Show the information contained in the selected message

    //Show a list of available commands

    //Wait for player command
}

/// <summary>
/// A screen that allows you to send a message to a customer.
/// </summary>
/// <param name="id">The id of the customer you want to send a message to</param>
void SendMessageScreen(int id)
{
    //Show basic event details (age limit, number of attendees, time left, etc) and notification icon

    //Show the information in the message to be sent

    //Show a list of available message subjects

    //Show a list of available commands

    //Wait for player command
}

/// <summary>
/// A screen that shows a list of all current attendees.
/// </summary>
void AttendeeListScreen()
{
    //Show basic event details (age limit, number of attendees, time left, etc) and notification icon

    //Show a list of attendees with basic details like ID, full name, email adress and discount code

    //Show a list of available commands

    //Wait for player command
}

/// <summary>
/// A screen that shows all info about a specific attendee, including their message history.
/// </summary>
/// <param name="a">The attendee to show information about</param>
/// <param name="editMode">True if editing an existing attendee, false if adding a new one</param>
void AttendeeScreen(Attendee a, bool editMode)
{
    //Show basic event details (age limit, number of attendees, time left, etc) and notification icon

    //Show extended details about the selected attendee

    //Show a list of messages sent by the attendee

    //Show a list of available commands

    //Wait for player command
}

/// <summary>
/// A screen shown at the end of the game, where the player sees their stats, score and customer reviews.
/// </summary>
void EndScreen()
{
}