INSERT INTO Instructor (Ins_Id, Ins_Name, Ins_Email, Ins_Password)
VALUES 
(1, 'Ali Abdullah', 'ali.abdullah@example.com', 'password1'),
(2, 'Fatima Ahmed', 'fatima.ahmed@example.com', 'password2'),
(3, 'Hassan Ibrahim', 'hassan.ibrahim@example.com', 'password3'),
(4, 'Sara Khalid', 'sara.khalid@example.com', 'password4'),
(5, 'Mona Hamza', 'mona.hamza@example.com', 'password5'),
(6, 'Ahmed Hassan', 'ahmed.hassan@example.com', 'password6'),
(7, 'Nada Mohamed', 'nada.mohamed@example.com', 'password7'),
(8, 'Adel Saleh', 'adel.saleh@example.com', 'password8'),
(9, 'Rania Ali', 'rania.ali@example.com', 'password9'),
(10, 'Tarek Mahmoud', 'tarek.mahmoud@example.com', 'password10'),
(11, 'Hoda Samir', 'hoda.samir@example.com', 'password11'),
(12, 'Khaled Mustafa', 'khaled.mustafa@example.com', 'password12'),
(13, 'Amal Hassan', 'amal.hassan@example.com', 'password13'),
(14, 'Hisham Ali', 'hisham.ali@example.com', 'password14'),
(15, 'Rania Abdelrahman', 'rania.abdelrahman@example.com', 'password15'),
(16, 'Ayman Ahmed', 'ayman.ahmed@example.com', 'password16'),
(17, 'Noha Mohamed', 'noha.mohamed@example.com', 'password17'),
(18, 'Mohamed Saleh', 'mohamed.saleh@example.com', 'password18'),
(19, 'Hassan Ali', 'hassan.ali@example.com', 'password19'),
(20, 'Ghada Ibrahim', 'ghada.ibrahim@example.com', 'password20');
----------------------------------------------------------------------------------------
INSERT INTO Department (Dept_Id, Dept_Name, Manager_Id)
VALUES 
(1, 'Professional Web Development', 1),
(2, 'Open Source Applications', 2),
(3, 'Artificial Intelligence', 3),
(4, 'System Administration', 4),
(5, 'Native Mobile Applications', 5);
----------------------------------------------------------------------------------------
INSERT INTO Student (St_Id, St_Name, Email, [Password], Dept_Id)
VALUES
    (1, 'Ahmad Ali', 'ahmad.ali@example.com', 'password123', 1),
(2, 'Sara Ahmed', 'sara.ahmed@example.com', 'password123', 2),
(3, 'Mohamed Hassan', 'mohamed.hassan@example.com', 'password123', 3),
(4, 'Fatima Khalid', 'fatima.khalid@example.com', 'password123', 4),
(5, 'Yousef Khalil', 'yousef.khalil@example.com', 'password123', 5),
(6, 'Mariam Hamed', 'mariam.hamed@example.com', 'password123', 1),
(7, 'Omar Samir', 'omar.samir@example.com', 'password123', 2),
(8, 'Aisha Reda', 'aisha.reda@example.com', 'password123', 3),
(9, 'Ali Mahmoud', 'ali.mahmoud@example.com', 'password123', 4),
(10, 'Nour Mohamed', 'nour.mohamed@example.com', 'password123', 5),
(11, 'Hassan Sami', 'hassan.sami@example.com', 'password123', 1),
(12, 'Hoda Nasser', 'hoda.nasser@example.com', 'password123', 2),
(13, 'Salma Tarek', 'salma.tarek@example.com', 'password123', 3),
(14, 'Khaled Yahya', 'khaled.yahya@example.com', 'password123', 4),
(15, 'Jana Ahmed', 'jana.ahmed@example.com', 'password123', 5),
(16, 'Omar Farouk', 'omar.farouk@example.com', 'password123', 1),
(17, 'Maha Samir', 'maha.samir@example.com', 'password123', 2),
(18, 'Khalid Mohamed', 'khalid.mohamed@example.com', 'password123', 3),
(19, 'Aisha Reda', 'aisha.reda@example.com', 'password123', 4),
(20, 'Youssef Ali', 'youssef.ali@example.com', 'password123', 5),
(21, 'Hossam Khalil', 'hossam.khalil@example.com', 'password123', 1),
(22, 'Mona Salem', 'mona.salem@example.com', 'password123', 2),
(23, 'Noura Mahmoud', 'noura.mahmoud@example.com', 'password123', 3),
(24, 'Mahmoud Mohamed', 'mahmoud.mohamed@example.com', 'password123', 4),
(25, 'Laila Ahmed', 'laila.ahmed@example.com', 'password123', 5),
(26, 'Yara Hassan', 'yara.hassan@example.com', 'password123', 1),
(27, 'Saeed Ali', 'saeed.ali@example.com', 'password123', 2),
(28, 'Ola Tarek', 'ola.tarek@example.com', 'password123', 3);

----------------------------------------------------------------------------------------
INSERT INTO Course (Cr_Id, Cr_Name)
VALUES (1, 'HTML and CSS'),
       (2, 'JavaScript Fundamentals'),
       (3, 'Responsive Web Design'),
   
	   (4, 'Linux Essentials'),
       (5, 'Open Source Software'),
       (6, 'Version Control with Git'),

	   (7, 'Introduction to AI'),
       (8, 'Machine Learning Fundamentals'),
       (9, 'Deep Learning with TensorFlow'),

       (10, 'Windows Server Administration'),
       (11, 'Network Administration'),
       (12, 'Virtualization and Cloud Computing'),

	   (13, 'Introduction to Mobile Development'),
       (14, 'Android App Development'),
       (15, 'iOS App Development'),
       (16, 'Cross-Platform Mobile Development');
----------------------------------------------------------------------------------------
INSERT INTO Topic (Cr_Id, Topic_Name)
VALUES 
   (1, 'HTML Basics'),
   (1, 'CSS Styling'),
   (2, 'JavaScript Syntax'),
   (2, 'DOM Manipulation'),
   (3, 'Media Queries'),
   (3, 'Flexbox Layout'),
   (4, 'Command Line Basics'),
   (4, 'Package Management'),
   (5, 'Open Source Licensing'),
   (5, 'Contributing to Open Source Projects'),
   (6, 'Git Workflow'),
   (6, 'Branching and Merging'),
   (7, 'AI Applications'),
   (7, 'Supervised Learning'),
   (8, 'Linear Regression'),
   (8, 'Classification Algorithms'),
   (9, 'Convolutional Neural Networks'),
   (9, 'Recurrent Neural Networks'),
   (10, 'Active Directory'),
   (10, 'Group Policy Management'),
   (11, 'Network Topologies'),
   (11, 'Routing Protocols'),
   (12, 'Virtualization Technologies'),
   (12, 'Cloud Deployment Models'),
   (13, 'Mobile App UI Design'),
   (13, 'Mobile App Testing'),
   (14, 'Android Activity Lifecycle'),
   (14, 'User Interface Components'),
   (15, 'iOS App Architecture'),
   (15, 'View Controllers and Storyboards'),
   (16, 'React Native'),
   (16, 'Flutter');

----------------------------------------------------------------------------------------
--INSERT INTO Question (Q_Id, Q_Content, [type], Correct_Ans, Topic_Name, Cr_Id)
--VALUES
--	(1, 'What does HTML stand for?', 'MCQ', 'Hyper Text Markup Language', 'Introduction to HTML', 1),
--	(2, 'What is the correct way to create a link in HTML?', 'MCQ', '<a href="url">link text</a>', 'Introduction to HTML', 1),
--	(3, 'HTML is a programming language?', 'TF', 'False', 'Introduction to HTML', 1),
--	(4, 'What is the correct HTML element for the largest heading?', 'MCQ', '<h1>', 'Introduction to HTML', 1),
--	(5, 'What does CSS stand for?', 'MCQ', 'Cascading Style Sheets', 'Introduction to CSS', 1),
--	(6, 'Which property is used to change the background color?', 'MCQ', 'background-color', 'Introduction to CSS', 1),
--	(7, 'CSS is used to define the structure of a web page?', 'TF', 'False', 'Introduction to CSS', 1),
--	(8, 'Which CSS property is used to control the text size?', 'MCQ', 'font-size', 'Introduction to CSS', 1);
	
--INSERT INTO Question (Q_Id, Q_Content, [type], Correct_Ans, Topic_Name, Cr_Id)
--VALUES
--	(9, 'What is the correct syntax for declaring a variable in JavaScript?', 'mcq', 'var myVariable;', 'JavaScript Syntax', 2),
--	(10, 'What is the difference between == and === in JavaScript?', 'mcq', '== performs type coercion while === does not', 'JavaScript Syntax', 2),
--	(11, 'What is the DOM?', 'mcq', 'The Document Object Model is a programming interface for web documents.', 'DOM Manipulation', 2),
--	(12, 'What is the getElementById() method used for in JavaScript?', 'mcq', 'It is used to access a single element in the DOM by its ID.', 'DOM Manipulation', 2),
--	(13, 'What is the difference between the textContent and innerHTML properties in JavaScript?', 'mcq', 'textContent returns the text within an element while innerHTML returns the text and HTML within an element.', 'DOM Manipulation', 2),
--	(14, 'What is event bubbling in JavaScript?', 'mcq', 'Event bubbling is the propagation of events from child elements to parent elements in the DOM.', 'DOM Manipulation', 2),
--	(15, 'How do you add an event listener to an HTML element in JavaScript?', 'mcq', 'You can use the addEventListener() method.', 'DOM Manipulation', 2),
--	(16, 'What is the difference between preventDefault() and stopPropagation() in JavaScript?', 'mcq', 'preventDefault() stops the default behavior of an event while stopPropagation() stops the event from propagating to parent elements.', 'DOM Manipulation', 2),
--	(17, 'What is the purpose of the setTimeout() method in JavaScript?', 'mcq', 'It is used to execute a function after a specified amount of time.', 'DOM Manipulation', 2),
--	(18, 'What is the difference between a NodeList and an HTMLCollection in JavaScript?', 'mcq', 'A NodeList is a list of nodes that can contain any type of node while an HTMLCollection is a list of elements only.', 'DOM Manipulation', 2);

