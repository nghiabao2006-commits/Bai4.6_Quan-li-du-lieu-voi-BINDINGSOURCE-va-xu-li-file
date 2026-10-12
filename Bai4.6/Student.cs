using System;
using System.ComponentModel;

namespace Bai4._6
{
    public class Student : INotifyPropertyChanged
    {
        private string studentId;
        private string fullName;
        private int age;
        private string gender;
        private string avatarPath;

        public string StudentId
        {
            get => studentId;
            set { if (studentId != value) { studentId = value; OnPropertyChanged(nameof(StudentId)); } }
        }

        public string FullName
        {
            get => fullName;
            set { if (fullName != value) { fullName = value; OnPropertyChanged(nameof(FullName)); } }
        }

        public int Age
        {
            get => age;
            set { if (age != value) { age = value; OnPropertyChanged(nameof(Age)); } }
        }

        public string Gender
        {
            get => gender;
            set { if (gender != value) { gender = value; OnPropertyChanged(nameof(Gender)); } }
        }

        public string AvatarPath
        {
            get => avatarPath;
            set { if (avatarPath != value) { avatarPath = value; OnPropertyChanged(nameof(AvatarPath)); } }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
