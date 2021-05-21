/*
 * Title: Ranorex Flashcards Rough Data
 * Author: Marc Funston
 * Purpose: Flashcards Database.
 * Edit: 5/21/2021 Intial build
 *
 */

DROP DATABASE IF EXISTS ranorex;

CREATE DATABASE ranorex;

USE ranorex;

CREATE TABLE users (
user_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
first_name VARCHAR(20),
last_name VARCHAR(40),
admin BOOL,
user_name VARCHAR(40) NOT NULL,
email VARCHAR(60) NOT NULL,
password VARCHAR(40) NOT NULL,
registration_date DATETIME NOT NULL,
PRIMARY KEY (user_id)
);


CREATE TABLE cards (
card_number INT UNSIGNED NOT NULL AUTO_INCREMENT,
user_id TINYINT UNSIGNED,
card_title VARCHAR(40) NOT NULL,
question VARCHAR(1024),
answer VARCHAR(1024),
image_name VARCHAR(60),
views INT UNSIGNED,
card_date DATETIME NOT NULL,
PRIMARY KEY (card_number),
INDEX (user_id),
INDEX (card_date)
);

CREATE TABLE messages (
user_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
email TINYINT UNSIGNED NOT NULL,
message VARCHAR(255) NOT NULL,
contact_date DATETIME NOT NULL,
PRIMARY KEY (user_id)
);

CREATE TABLE pictures(
picture_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
user_id TINYINT UNSIGNED NOT NULL,
title VARCHAR(20),
description VARCHAR(20),
link VARCHAR(128),
PRIMARY KEY(picture_id)
);

CREATE TABLE map_users_to_posts(
user_id TINYINT UNSIGNED NOT NULL, #fk
card_number INT UNSIGNED NOT NULL, #fk
PRIMARY KEY(user_id,card_number)
);

CREATE TABLE comments(
comment_id TINYINT UNSIGNED NOT NULL AUTO_INCREMENT,
comment VARCHAR(144),
user_id TINYINT UNSIGNED,
card_number INT UNSIGNED NOT NULL,
card_date DATETIME NOT NULL,
PRIMARY KEY(comment_id)
);

CREATE TABLE views(
card_number INT UNSIGNED NOT NULL AUTO_INCREMENT,
total INT UNSIGNED NOT NULL,
PRIMARY KEY(card_number)
);

alter table views
add foreign key(card_number)
references cards(card_number)
on delete cascade;

alter table comments
add foreign key(card_number)
references cards(card_number)
on delete cascade;

alter table comments
add foreign key(user_id)
references users(user_id)
on delete cascade;

alter table map_users_to_posts
add foreign key(user_id)
references users(user_id)
on delete cascade;

alter table map_users_to_posts
add foreign key(card_number)
references cards(card_number)
on delete cascade;

alter table messages
add foreign key(user_id)
references users(user_id)
on delete cascade;

alter table pictures
add foreign key(user_id)
references users(user_id)
on delete cascade;

/* this data is sanitized for upload to git*/

INSERT INTO users (first_name, last_name, admin, user_name, email, password, registration_date) VALUES
('Marc', 'F', true, 'admin', 'admin', SHA1('pass'), now()),
('Marc', 'F', false, 'marc', 'marc', SHA1('pass'), now());	

INSERT INTO `cards` (`card_number`, `user_id`, `card_title`, `question`, `answer`, `image_name`, `views`, `card_date`) VALUES
(1, 1, '1', 'What is GUI testing?', 'GUI testing refers to testing the functions of an application that are visible to a user.', 'ISS.png', 0, '2021-05-21 11:51:27'),
(2, 1, '2', 'What is the difference between UI testing and GUI testing?', 'Answer', 'ISS.png', 0, '2021-05-21 11:57:37'),
(3, NULL, '3', 'What is the difference between UI testing and GUI testing?', 'UI is a broader concept that can include both GUI and Command Line Interfaces (CLIs). GUI testing would also confirm that appearance elements such as fonts and colors conform to design specifications.', 'ISS.png', 0, '2021-05-21 12:17:23'),
(4, NULL, '4', 'Why is GUI testing important?', 'GUI testing can provide a project team with information they need to decide whether an application is ready to deploy. It also can evaluate functionality that may be missing or issues with an application’s visual elements and ease-of-use.', 'ISS.png', 0, '2021-05-21 12:17:59'),
(5, NULL, '5', 'What are the major GUI testing techniques?', 'Scripted testing, exploratory testing, user experience testing', 'ISS.png', 0, '2021-05-21 12:18:26'),
(6, NULL, '6', 'Scripted testing', 'In scripted testing, software testers design and then execute pre-planned scripts to uncover defects and verify that an application does what it is supposed to do.', 'ISS.png', 0, '2021-05-21 12:18:57'),
(7, NULL, '7', 'Exploratory testing', 'Rather than following pre-written test scripts, exploratory testers draw on their knowledge and experience to learn about the AUT, design tests and then immediately execute the tests.', 'ISS.png', 0, '2021-05-21 12:19:22'),
(8, NULL, '8', 'User experience testing', 'In user experience testing, actual end-users or user representatives evaluate an application for its ease of use, visual appeal, and ability to meet their needs.', 'ISS.png', 0, '2021-05-21 12:20:10'),
(9, NULL, '9', 'How to write a GUI test plan', 'A GUI test plan sets the scope of a test project. Before writing test cases, it is important to have a test plan that identifies the resources available for testing and that prioritizes areas of the application to be tested.', 'ISS.png', 0, '2021-05-21 12:20:32'),
(10, NULL, '10', 'How to write GUI test scenarios', 'A test scenario is a brief statement of how an application will be used in real-life situations, such as “the user will be able to log in with a valid username and password.” Test scenarios can be written from development documents such as requirements, acceptance criteria, and user stories.', 'ISS.png', 0, '2021-05-21 12:21:07'),
(11, NULL, '11', 'How to write GUI test cases', 'To write a GUI test case, start with a description of a GUI event to be tested, such as a login attempt. Then, add the conditions and procedures for executing the test. Finally, identify the expected result of the test and criteria for determining whether the test succeeds or fails.', 'ISS.png', 0, '2021-05-21 12:21:32'),
(12, NULL, '12', 'Best practices in writing GUI test cases', 'Separate test data from test cases\r\nKeep test cases modular\r\nWrite positive and negative test cases\r\nUse testing heuristics', 'ISS.png', 0, '2021-05-21 12:22:07'),
(13, NULL, '13', 'What are testing heuristics?', 'When creating data for test cases, it is useful to draw on testing heuristics. For example, create test data for the maximum and minimum values in a data field. Or, when testing queries against a database, have tests for a query that returns zero rows, one row, or multiple rows.', 'ISS.png', 0, '2021-05-21 12:22:33'),
(14, NULL, '14', 'Integrated Recorder', 'When you start a new test project, the working environment appears with an empty recording module opened.\r\n1) Active recording module Recording1.rxrec\r\n2) Control panel of the integrated Recorder', 'ISS.png', 0, '2021-05-21 12:36:46'),
(15, NULL, '15', 'Stand-alone Recorder', 'Ranorex also provides a stand-alone Recorder. It can be started independently from Ranorex Studio.\r\n1) Open the Windows Start menu.\r\n2) Click Ranorex > Ranorex Recorder 8.\r\n3) Start the stand-alone Recorder in the desired version (32 or 64 bit).', 'ISS.png', 0, '2021-05-21 12:37:12'),
(16, NULL, '16', 'Integrated vs. stand-alone Recorder', 'Both Recorder versions are identical in their basic functionality. However, the stand-alone Recorder has fewer features. That’s why we recommend that you use the integrated Recorder.', 'ISS.png', 0, '2021-05-21 12:37:35'),
(17, NULL, '17', 'Integrated vs. stand-alone Recorder', 'One major difference is that the stand-alone Recorder does not allow user code actions, which are popular in automated testing. The stand-alone Recorder also uses an embedded repository by default. This can be limiting when dealing with more complex testing tasks.', 'ISS.png', 0, '2021-05-21 12:38:13'),
(18, NULL, '18', 'Test suite', 'The test suite is where you build, organize, and run your tests in Ranorex Studio. A test suite consists primarily of test cases, which are in turn built from modules. You can add smart folders to structure your test. The test suite is also where you configure variables and data binding for ⇢ data-driven testing. You can run test suites in Ranorex Studio or the stand-alone Ranorex Test Suite Runner.', 'ISS.png', 0, '2021-05-21 12:41:36'),
(19, NULL, '19', 'The test suite file', 'Each test suite is contained in a special file with the extension .rxtst (for Ranorex test suite). Test suite files are always part of a project, and you can find them in the projects view. A project may contain multiple test suite files.', 'ISS.png', 0, '2021-05-21 12:42:20'),
(20, NULL, '20', 'The test suite view', 'To open the test suite, double click the test suite file. The test suite view appears. This is where you work on your test suite.', 'ISS.png', 0, '2021-05-21 12:43:04'),
(21, NULL, '21', 'Actions', 'An action is an individual activity performed by a module. In Ranorex, there are two groups of actions: basic and smart actions. Basic actions represent direct user input, such as mouse clicks. Smart actions represent more complex input or special functions, such as running a browser or carrying out a validation. Most actions are performed on repository items. Actions are managed in the actions table in the Recorder view.', 'ISS.png', 0, '2021-05-21 12:43:28'),
(22, NULL, '22', 'Basic actions', 'Basic actions represent direct user input with or on a device such as mouse clicks or keyboard input. These actions are automatically recorded when you perform them during a recording, but can also be added manually in the actions table.', 'ISS.png', 0, '2021-05-21 12:44:05'),
(23, NULL, '23', 'Smart actions', 'Smart actions represent more complex UI interactions and functions. For example, the Run application action directly runs an executable from a specific path without the mouse clicks or keyboard interactions normally required to do so. During a recording, none of these actions are available, except for the Validation action.', 'ISS.png', 0, '2021-05-21 12:44:36'),
(24, NULL, '24', 'Smart actions', 'Validation, \r\nInvoke action, \r\nGet value, \r\nSet value, \r\nOpen browser, \r\nRun application, \r\nRun mobile application, \r\nDeploy Android app, \r\nDeploy iOS app, \r\nSet device orientation, \r\nClose application, \r\nWait for, \r\nLog message, \r\nCapture screenshot, \r\nCreate snapshot, \r\nSeparator, \r\nDelay, \r\nUser code', 'ISS.png', 0, '2021-05-21 12:46:59'),
(25, NULL, '25', 'Repository', 'A repository contains representations of user interface (UI) elements used in a test, called “repository items.” Repository items are organized in a tree-like structure. Each item has a RanoreXPath that uniquely identifies it and allows Ranorex to link the item with the corresponding UI element of the AUT.', 'ISS.png', 0, '2021-05-21 12:47:40'),
(26, NULL, '26', 'UI elements', 'Ranorex Studio tests consist of a series of interactions with elements in an application’s user interface. UI elements include buttons, tabs, drop-down menus, text fields, and so on. Ranorex Studio represents UI elements as repository items in order to work with them.', 'ISS.png', 0, '2021-05-21 12:48:08'),
(27, NULL, '27', 'The repository and repository items', 'Repository items are stored and managed in the repository in a tree-like structure. To access the repository, open the repository file from the projects view. The repository file also opens automatically when you open a recording module. By default, the repository appears in the lower section of the Ranorex Studio work area.', 'ISS.png', 0, '2021-05-21 12:48:48'),
(28, NULL, '28', 'Repository structure', 'Repositories are organized in a tree-like structure that follows the internal structure of the AUT’s UI. UI elements that contain other UI elements are represented as folders in the repository, with app folders acting as top-level elements and rooted folders as children.', 'ISS.png', 0, '2021-05-21 12:49:25'),
(29, NULL, '29', 'The repository file', 'The contents of the repository are stored in a repository file. As with other Ranorex files, you can access it from the projects view or in the project’s folder in Windows. Each repository file also has two subfiles.', 'ISS.png', 0, '2021-05-21 12:49:59'),
(30, NULL, '30', 'Repository file', 'The repository file has the file ending .rxrep, which stands for Ranorex repository.\r\nThe default file name is a combination of the parent test solution (i.e. Introduction) and Repository. You can rename the file to your liking.', 'ISS.png', 0, '2021-05-21 12:50:48'),
(31, NULL, '31', 'Image hosting file', 'The file with the ending .rximg hosts all screenshots linked to repository items.', 'ISS.png', 0, '2021-05-21 12:51:25'),
(32, NULL, '32', 'Test validation', 'In software testing, validation is the process of verifying that the behavior and/or responses produced by the application under test match the expected results.', 'ISS.png', 0, '2021-05-21 12:52:27'),
(33, NULL, '33', 'Understanding validation', 'Let’s begin with a simple example of test validation. Imagine a standard pocket calculator that you use to add two numbers. Test validation succeeds if the calculator returns the expected result.', 'ISS.png', 0, '2021-05-21 12:53:18'),
(34, NULL, '34', 'Indirect validation', 'It is important to understand that GUI test automation provides indirect test validation only. Indirect validation verifies that the displayed result is similar to the expected result based on the user input. It does not ensure whether the calculator works correctly.', 'ISS.png', 0, '2021-05-21 12:54:21'),
(35, NULL, '35', 'Validation Process', 'Activate validation, Select the validation element, Confirm the validation element, Define validation attributes', 'ISS.png', 0, '2021-05-21 12:55:59'),
(36, NULL, '36', 'Activate validation', 'Within Ranorex, validation is treated as a special type of action. So, to “activate” a test validation simply means to add a validation action to the current recording module.', 'ISS.png', 0, '2021-05-21 12:56:40'),
(37, NULL, '37', 'Select the validation element', 'The second step of the validation process is to select the UI element to be validated. The selection process is independent of the type of validation (i.e. text/attribute/image-based validation).', 'ISS.png', 0, '2021-05-21 12:57:15'),
(38, NULL, '38', 'Confirm the validation element', 'The third step of the validation process is to confirm that the correct UI element was selected for validation. If so, click Next. Otherwise, correct the selection.', 'ISS.png', 0, '2021-05-21 12:57:50'),
(39, NULL, '39', 'Define validation attributes', 'Each UI element is defined by states and attributes. During the final step, specify the particular attribute or state to be used for validation, as shown below.', 'ISS.png', 0, '2021-05-21 12:58:22'),
(40, NULL, '40', 'Whitelisting', 'When identifying UI elements, Ranorex Studio and its components scan all running processes on your computer by default. With whitelisting, you can focus Ranorex Studio on only the processes relevant for your test.', 'ISS.png', 0, '2021-05-21 12:59:09'),
(41, NULL, '41', 'Reporting', 'Every test run in Ranorex Studio ends with a report. After all, how else would you know whether the test run was successful or not? The report details the entire test run from beginning to start, i.e. how many test cases succeeded, failed, or were blocked; what errors and warnings were raised; the iterations of a given test container; and so on. You can customize reports to change what information is displayed or add your own logos, for example. Finally, you can also export reports.', 'ISS.png', 0, '2021-05-21 13:00:14'),
(42, NULL, '42', 'Data-driven testing', 'In data-driven testing, a test container (test case/smart folder) retrieves input values from a data source such as an Excel spreadsheet or a database file. The test container is then repeated automatically for each row of data in the data source.', 'ISS.png', 0, '2021-05-21 13:01:16'),
(43, NULL, '43', 'Tracking UI elements', 'Automated UI testing is based on identifying UI elements and generating a representation of them that the automation tool can work with, i.e. repository items with a unique RanoreXPath. In Ranorex Studio, this is accomplished through tracking UI elements.', 'ISS.png', 0, '2021-05-21 13:02:10'),
(44, NULL, '44', 'Ranorex Spy', 'Ranorex Spy is the component of Ranorex Studio that makes it possible to explore and analyze the UI of desktop, mobile, and web applications for the purpose of identifying UI elements. Spy captures all running applications (according to your >⇢ whitelist) and displays them and their subelements in a tree view. It therefore recognizes UI elements, identifies them, assigns a RanoreXPath to them, and ultimately makes them available as repository items to Ranorex Studio.', 'ISS.png', 0, '2021-05-21 13:03:16'),
(45, NULL, '45', 'Track function', 'Ranorex Spy has a track function that lets you identify UI elements and add them to the element tree, from where you can then add them to your repository.', 'ISS.png', 0, '2021-05-21 13:03:43'),
(46, NULL, '46', 'UI elements', 'Graphical user interface elements (i.e. UI elements) are the graphical elements on a computer screen that represent stored information within computers and allow users to interact with the software. Common examples are windows, text fields, buttons, labels, lists, selection elements.', 'ISS.png', 0, '2021-05-21 13:05:01'),
(47, NULL, '47', 'RanoreXPath', 'The purpose of RanoreXPath expressions is to uniquely identify UI elements in a desktop, web, or mobile application. Without RanoreXPath, Ranorex Studio couldn’t find the UI elements it’s supposed to perform actions on.', 'ISS.png', 0, '2021-05-21 13:06:29'),
(48, NULL, '48', 'Maintenance mode', 'Maintenance mode allows you to catch and resolve certain errors during test execution. You can then apply the fixes to your test suite from the report. This saves time because you don’t have to let the entire test run through to start diagnosing and fixing errors.', 'ISS.png', 0, '2021-05-21 13:07:31'),
(49, NULL, '49', 'Activate maintenance mode', 'Under Build > Set configuration, ensure Debug is enabled. The option is usually enabled by default. It is not the same as the debug mode you enable from the menu bar.', 'ISS.png', 0, '2021-05-21 13:08:12'),
(50, NULL, '50', 'Catch and resolve errors', 'When maintenance mode is active, it catches errors native to Ranorex Studio and pauses test execution upon doing so. Depending on the error type, different dialogs with different options will appear.', 'ISS.png', 0, '2021-05-21 13:12:29');
