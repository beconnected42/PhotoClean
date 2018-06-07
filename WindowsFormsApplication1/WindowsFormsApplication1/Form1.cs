using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ExifLib;  // 사진파일의 정보를 가져올 수 있음

namespace WindowsFormsApplication1
{
    public partial class 파일정리프로그램 : Form
    {
        private readonly string[] fileExtensions = new[] { "jpg", "gif" };  // 값 고정 (변수를 상수로)
        private string filePath;                                            // 파일의  경로
        private List<string> fullFileNames;                                 // 파일의 풀네임을 가져오기위함
        private Dictionary<string, string> dicExifDatas;                    // 파일이 생성된 날짜
        private string fileListText = "File List (Count：{0})";             // 폴더 속 파일의 수

        bool copyType = true;  //라디오버튼 타입


        public 파일정리프로그램()
        {
            InitializeComponent();

        }

        private void MovePic()
        {
            try
            {
                foreach (var dicExifData in this.dicExifDatas)  // 사진촬영정보를 가져옴 (생성날짜)
                {
                    var date = dicExifData.Value.Replace('/', '-');

                    var newPath = this.filePath + "\\" + date; // 새로운 경로의 이름을 날짜로 지정함
                    if (!Directory.Exists(newPath))            // 경로가 없으면
                    {                                        
                        Directory.CreateDirectory(newPath);    // 경로를 만듬
                    }

                    var fileInfo = new FileInfo(dicExifData.Key);  // 파일의 정보
                    if (fileInfo.Exists)         // 파일의 정보가 있으면
                    {
                        if (!this.CheckFileIsExists(newPath + "\\" + fileInfo.Name))   
                        {
                            if (copyType)// 복사
                            {
                                fileInfo.CopyTo(newPath + "\\" + fileInfo.Name);  // 파일정보를 새로운 경로에 복사한다
                            }
                            else // 이동
                            {
                                System.IO.File.Move(fileInfo.FullName, newPath + "\\" + fileInfo.Name);  // 파일의 정보를 새로운 경로로 이동한다
                            }
                        }
                        else
                        {
                            // 존재하면 이름을 한 번 바꿈
                            var extensionIndex = fileInfo.Name.LastIndexOf(".", StringComparison.Ordinal);
                            var newFileName = fileInfo.Name.Substring(0, extensionIndex) + "_1" + fileInfo.Extension;

                            if (!this.CheckFileIsExists(newPath + "\\" + newFileName))
                            {
                                fileInfo.MoveTo(newPath + "\\" + newFileName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {}
            this.Reset();
            MessageBox.Show("완료");  // 완료라는 메세지박스를 띄운다
        }

        private void Reset()  // 초기화
        {
            this.filePath = string.Empty; // 파일경로 초기화
            this.fullFileNames = new List<string>();   // 파일 풀네임 초기화
            this.dicExifDatas = new Dictionary<string, string>(); // 파일이 생성된 날짜 초기화

            this.boxPhoto.Items.Clear();  // 포토박스 초기화

        }

        private bool CheckFileIsExists(string path) 
        {
            var fileInfo = new FileInfo(path);
            return fileInfo.Exists;
        }

        private void boxPhoto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var box = (ListBox)sender;
            var fileName = this.fullFileNames[box.SelectedIndex];
            imgBox.ImageLocation = fileName;
        }

        private void rbtn_Copy_CheckedChanged_1(object sender, EventArgs e)
        {
            copyType = true;
        }

        private void rbtn_Move_CheckedChanged_1(object sender, EventArgs e)
        {
            copyType = false;
        }

        // 폴더내 파일을 가져온다
        private void btn_newPath_Click_1(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))           // text박스1에 경로를 넣으면
            {
                folderBrowserDialog1.ShowDialog();                  // 사용자가 폴더를 선택하는 대화상자
                this.filePath = folderBrowserDialog1.SelectedPath;  // 파일의 경로는 사용자가 선택한 경로
            }
            else   //아니면
            {
                this.filePath = textBox1.Text;  
            }

            if (string.IsNullOrWhiteSpace(this.filePath))  // 폴더를 입력하지 않고 버튼을 클릭했을 때
            {
                MessageBox.Show("폴더를 입력하시오");
                return;
            }
            else if (!Directory.Exists(this.filePath))     // 폴더가 존재하지 않을 때
            {
                MessageBox.Show("폴더 에러");
                return;
            }

            this.GetFullFileName();               // 폴더내 파일의 풀네임을 받음

            if (this.fullFileNames.Count == 0)    // 폴더에 사진이 없을 때            
            {
                MessageBox.Show("폴더에 사진이 없어요");
                return;
            }

            var fileNames = this.GetFileName(fullFileNames);    // 파일이름 가져옴

            boxPhoto.Items.Clear();   // 포토박스 초기화

            foreach (var fileName in fileNames)  // 파일이름을 모두 불러옴
            {
                boxPhoto.Items.Add(fileName);    // 포토박스에 파일이름을 출력
            }

            lblFileList.Text = string.Format(this.fileListText, boxPhoto.Items.Count);  // string형식으로 바꿈

            List<string> errorFileNames;
            dicExifDatas = this.GetExifDateTime(fullFileNames, out errorFileNames);

           
        }

        // 파일네임 리스트만듬
        private List<string> GetFileName(List<string> fullFileName)
        {
            var fileNames = new List<string>();

            foreach (var tempFile in fullFileName)
            {
                var fileInfo = new FileInfo(tempFile);
                fileNames.Add(fileInfo.Name);
            }

            return fileNames;
        }

        // 파일 정보 받음
        private Dictionary<string, string> GetExifDateTime(List<string> fullFileNames, out List<string> errorFileNames)
        {
            var dic = new Dictionary<string, string>();
            errorFileNames = new List<string>();

            foreach (var fileName in fullFileNames)
            {
                try
                {
                    using (var reader = new ExifReader(fileName))
                    {
                        DateTime dt;
                        reader.GetTagValue(ExifTags.DateTimeOriginal, out dt);

                        if (!dic.ContainsKey(fileName))
                        {
                            dic.Add(fileName, dt.ToString("yyyy/MM/dd"));
                        }
                        else
                        {
                            errorFileNames.Add(fileName + " 파일이름 중복");
                        }
                    }
                }
                catch (Exception ex)
                {
                    errorFileNames.Add(fileName + " 확인할 수 없습니다");
                }
            }

            return dic;
        }

        // 파일 이름 받음
        private void GetFullFileName()
        {
            this.fullFileNames = new List<string>();

            foreach (var extension in fileExtensions)
            {
                var tempFilesNames = Directory.GetFiles(this.filePath, "*." + extension);
                this.fullFileNames.AddRange(tempFilesNames);
            }
        }
       
        // 복사 or 이동을 실행한다
        private void btn_Run_Click_1(object sender, EventArgs e)
        {
            if (this.dicExifDatas == null || this.dicExifDatas.Count == 0)
            {
                MessageBox.Show("폴더를 입력하시오");
                return;
            }

            this.MovePic();
        }

    }
}

