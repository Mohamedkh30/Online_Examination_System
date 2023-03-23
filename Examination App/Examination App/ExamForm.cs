using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_App
{
    public partial class ExamForm : Form
    {
        Examination_DBEntities1 Entity;
        ObjectParameter ExamNum;
        GenerateExam_Result CurrentQuestion;
        List<GenerateExam_Result> ExamQuestionsList;
        ObjectResult<GenerateExam_Result> ExamQuestionAsObjectResult;
        int CurrentIndexOfQuestion;
        List<GroupBox> ChoicesAreaList;
        int Timer;
        Boolean ExitExam;
/*        List <string> Answers;
*/        private object myListLock = new object();

        public ExamForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Entity = new Examination_DBEntities1();
            CurrentIndexOfQuestion = 0;
            Timer = 60;
             int QuestionNum = 1;
/*            List<string> Answers= new List<string>();
*/             ExamNum = new ObjectParameter("Exam_Num",typeof(int));
            ExamQuestionsList = new List<GenerateExam_Result>();
            ExamQuestionAsObjectResult = Entity.GenerateExam("5", "5", "JavaScript Fundamentals", ExamNum);
            ChoicesAreaList = new List<GroupBox>();
            ExitExam = false;
            Thread thread = new Thread(ParralelMethod);
            thread.Start();



            foreach (var Question in ExamQuestionAsObjectResult)
            {
                ExamQuestionsList.Add(Question);
                Questions_List.Items.Add($"Question {QuestionNum}");        // add elements To List 
                QuestionNum++;

                // Generate choices 
            }
           Questions_List.SelectedIndex= 0;     // Initail Value To Question 
            HandleQuestionChange();

            foreach (var Question in ExamQuestionsList)
            {
                if (Question.type == "MCQ" || Question.type == "mcq")
                {
                    var choices = Entity.returnChoices(Question.Q_Id.ToString());
                  
                        GenerateChoices(choices);
                }
                else
                {
                    generateTF();
                }

            }


        }

        private void ParralelMethod() {
            while (true)
            {
                Thread.Sleep(1000);
                Timer--;
                try
                {
                    Invoke((MethodInvoker)delegate
                    {
                        time.Text = Timer.ToString();
                    });
                }catch(Exception ex) { }
        




                if (Timer == 0 || ExitExam == true)
                {
                    sendData();
                    Invoke((MethodInvoker)delegate
                    {
                    Submit.Enabled= false;
                    NextButton.Enabled= false;
                    PrevButton.Enabled= false;
                    });
                    
                    break;
                }
            }

        }


        private void sendData()
        {
            List<string> Answers = new List<string>();


            foreach (GroupBox choiceArea in ChoicesAreaList)
            {
                foreach (Control element in choiceArea.Controls)
                {
                    if (element is RadioButton radioBtn)
                    {
                        if (radioBtn.Checked)
                            {
                             Answers.Add(radioBtn.Text);
                            Entity.Insert_Answerd_Question("5", ExamNum.Value.ToString(), ExamQuestionsList[ChoicesAreaList.IndexOf(choiceArea)].Q_Id.ToString(), radioBtn.Text,0);
                            }
                        
                    }
                }
            }
        }
    

        private void Questions_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleQuestionChange();
            
        }


        private void GenerateChoices(ObjectResult <string> choices)
        {

            var ChoiceArea = new GroupBox();
            
            int x = 10, y = 15;  

            // RadioButton Proparties

            foreach ( var choice in choices)
            {
                var radioBtn_choice = new RadioButton();

            radioBtn_choice.AutoSize = true;
            radioBtn_choice.Location = new System.Drawing.Point(x, y);
            radioBtn_choice.Name = "radioButton1";
            radioBtn_choice.Size = new System.Drawing.Size(103, 20);
            radioBtn_choice.TabIndex = 0;
            radioBtn_choice.TabStop = true;
            radioBtn_choice.Text = choice;
            radioBtn_choice.UseVisualStyleBackColor = true;
                y+= 30;
            ChoiceArea.Controls.Add(radioBtn_choice);

            }


            // choice areaa proparties 
            ChoiceArea.Location = new System.Drawing.Point(12, 120);
            ChoiceArea.BackColor = Color.Transparent;
            ChoiceArea.Name = "groupBox1";
            ChoiceArea.Size = new System.Drawing.Size(630, 230);
            ChoiceArea.TabIndex = 27;
            ChoiceArea.TabStop = false;
            ChoiceArea.Text = "";
            ChoicesAreaList.Add(ChoiceArea);
            this.Controls.Add( ChoiceArea );
        }

        private void generateTF()
        {

            var ChoiceArea = new GroupBox();
            // RadioButton Proparties
             var choiceTrue = new RadioButton();
            var choiceFalse = new RadioButton();

                    //True
            choiceTrue.AutoSize = true;
            choiceTrue.Location = new System.Drawing.Point(20, 40);
            choiceTrue.Name = "radioButton1";
            choiceTrue.Size = new System.Drawing.Size(103, 20);
            choiceTrue.TabIndex = 0;
            choiceTrue.TabStop = true;
            choiceTrue.Text = "True";
            choiceTrue.UseVisualStyleBackColor = true;
            ChoiceArea.Controls.Add(choiceTrue);

                    // False
            choiceFalse.AutoSize = true;
            choiceFalse.Location = new System.Drawing.Point(20, 60);
            choiceFalse.Name = "radioButton1";
            choiceFalse.Size = new System.Drawing.Size(103, 20);
            choiceFalse.TabIndex = 0;
            choiceFalse.TabStop = true;
            choiceFalse.Text = "False";
            choiceFalse.UseVisualStyleBackColor = true;
            ChoiceArea.Controls.Add(choiceFalse);




            // choice areaa proparties 
            ChoiceArea.Location = new System.Drawing.Point(12, 120);
            ChoiceArea.BackColor = Color.Transparent;
            ChoiceArea.Name = "groupBox1";
            ChoiceArea.Size = new System.Drawing.Size(630, 230);
            ChoiceArea.TabIndex = 27;
            ChoiceArea.TabStop = false;
            ChoiceArea.Text = "";
            ChoicesAreaList.Add(ChoiceArea);
            this.Controls.Add(ChoiceArea);
        }

        private void HandleQuestionChange()     // when Question change
        {
            CurrentIndexOfQuestion = Questions_List.SelectedIndex;
            CurrentQuestion = ExamQuestionsList[CurrentIndexOfQuestion];
            QuestionContent.Text = CurrentQuestion.Q_Content;
            Current_Question_Label.Text = $"Qustion {CurrentIndexOfQuestion + 1} Of 10";

            foreach (var choicearea in ChoicesAreaList)
            {
                if(ChoicesAreaList.IndexOf(choicearea) == CurrentIndexOfQuestion)
                {
                    choicearea.Visible = true;
                }
                else
                {
                    choicearea.Visible = false;
                }
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(CurrentIndexOfQuestion<9)
            Questions_List.SelectedIndex = CurrentIndexOfQuestion+1;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (CurrentIndexOfQuestion >0)
                Questions_List.SelectedIndex = CurrentIndexOfQuestion - 1;

        }

        private void Submit_Click(object sender, EventArgs e)
        {
                        ExitExam = true; 

        }
    }
}
