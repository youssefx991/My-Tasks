using System;
using System.Collections.Generic;
using System.Text;

namespace MySharedLibrary.Models
{
    public static class TracksTreineesContext
    {
        public static int TrackID = 11;
        public static int TraineeID = 11;
        public static List<Track> tracks = new List<Track>
        {
            new Track {ID = 1, Name = "SD", Description = "Software Development"},
            new Track {ID = 2, Name = "DS", Description = "Data Science"},
            new Track {ID = 3, Name = "CS", Description = "Cyber Security"},
            new Track {ID = 4, Name = "AI", Description = "Artificial Intelligence"},
            new Track {ID = 5, Name = "Cloud", Description = "Cloud Computing"},
            new Track {ID = 6, Name = "IoT", Description = "Internet of Things"},
            new Track {ID = 7, Name = "Mobile", Description = "Mobile Development"},
            new Track {ID = 8, Name = "Game", Description = "Game Development"},
            new Track {ID = 9, Name = "DevOps", Description = "Development Operations"},
            new Track {ID = 10, Name = "QA", Description = "Quality Assurance"},
        };

        public static List<Trainee> trainees = new List<Trainee>
        {
            new Trainee { ID = 1, Name = "Ahmed Eid", Gender = Gender.Male, Email = "ahmed@iti.gov.eg", MobileNo = "01011112222", Birthdate = new DateTime(2001, 5, 10), IsGraduated = true, TrackID = 1 },
                new Trainee { ID = 2, Name = "Mona Zaki", Gender = Gender.Female, Email = "mona@iti.gov.eg", MobileNo = "01122223333", Birthdate = new DateTime(2002, 3, 15), IsGraduated = false, TrackID = 1 },
                new Trainee { ID = 3, Name = "Omar Said", Gender = Gender.Male, Email = "omar@iti.gov.eg", MobileNo = "01233334444", Birthdate = new DateTime(2001, 11, 20), IsGraduated = true, TrackID = 2 },
                new Trainee { ID = 4, Name = "Sara Amr", Gender = Gender.Female, Email = "sara@iti.gov.eg", MobileNo = "01544445555", Birthdate = new DateTime(2003, 1, 5), IsGraduated = false, TrackID = 3 },
                new Trainee { ID = 5, Name = "Ziad Noah", Gender = Gender.Male, Email = "ziad@iti.gov.eg", MobileNo = "01055556666", Birthdate = new DateTime(2002, 12, 12), IsGraduated = true, TrackID = 4 },
                new Trainee { ID = 6, Name = "Laila Gad", Gender = Gender.Female, Email = "laila@iti.gov.eg", MobileNo = "01166667777", Birthdate = new DateTime(2001, 8, 8), IsGraduated = true, TrackID = 5 },
                new Trainee { ID = 7, Name = "Adam Kareem", Gender = Gender.Male, Email = "adam@iti.gov.eg", MobileNo = "01277778888", Birthdate = new DateTime(2002, 9, 25), IsGraduated = false, TrackID = 6 },
                new Trainee { ID = 8, Name = "Hoda Eid", Gender = Gender.Female, Email = "hoda@iti.gov.eg", MobileNo = "01588889999", Birthdate = new DateTime(2001, 6, 30), IsGraduated = true, TrackID = 7 },
                new Trainee { ID = 9, Name = "Karem Ali", Gender = Gender.Male, Email = "karem@iti.gov.eg", MobileNo = "01099990000", Birthdate = new DateTime(2003, 2, 14), IsGraduated = false, TrackID = 8 },
                new Trainee { ID = 10, Name = "Nora Fady", Gender = Gender.Female, Email = "nora@iti.gov.eg", MobileNo = "01100001111", Birthdate = new DateTime(2002, 4, 10), IsGraduated = true, TrackID = 9 }
        };


        // Track CRUD
        public static void AddTrack(Track track)
        {
            track.ID = TrackID++;
            tracks.Add(track);
        }

        public static List<Track> GetAllTracks()
        {
            return tracks;
        }

        public static Track? GetTrackByID(int id)
        {
            return tracks.Find(t => t.ID == id);
        }


        public static void UpdateTrack(Track updatedTrack)
        {
            var existingTrack = GetTrackByID(updatedTrack.ID);
            if (existingTrack != null)
            {
                existingTrack.Name = updatedTrack.Name;
                existingTrack.Description = updatedTrack.Description;
            }
        }


        public static void DeleteTrack(int id)
        {
            var track = GetTrackByID(id);
            if (track != null)
            {
                tracks.Remove(track);
            }

            foreach (var trainee in trainees)
            {
                if (trainee.TrackID == id)
                {
                    trainee.TrackID = null; // Unassigned
                }
            }
        }


        // Trainee CRUD
        public static void AddTrainee(Trainee trainee)
        {
            trainee.ID = TraineeID++;
            trainees.Add(trainee);
        }

        public static List<Trainee> GetAllTrainees()
        {
            return trainees;
        }

        public static Trainee? GetTraineeByID(int id)
        {
            return trainees.Find(t => t.ID == id);
        }

        public static void UpdateTrainee(Trainee updatedTrainee)
        {
            var existingTrainee = GetTraineeByID(updatedTrainee.ID);
            if (existingTrainee != null)
            {
                existingTrainee.Name = updatedTrainee.Name;
                existingTrainee.Gender = updatedTrainee.Gender;
                existingTrainee.Email = updatedTrainee.Email;
                existingTrainee.MobileNo = updatedTrainee.MobileNo;
                existingTrainee.Birthdate = updatedTrainee.Birthdate;
                existingTrainee.IsGraduated = updatedTrainee.IsGraduated;
                existingTrainee.TrackID = updatedTrainee.TrackID;
            }
        }

        public static void DeleteTrainee(int id)
        {
            var trainee = GetTraineeByID(id);
            if (trainee != null)
            {
                trainees.Remove(trainee);
            }
        }

        // Additional helper methods
        public static List<Trainee> GetTraineesByTrackID(int trackId)
        {
            return trainees.FindAll(t => t.TrackID == trackId);
        }

        public static string GetTrackNameByID(int trackId)
        {
            var track = GetTrackByID(trackId);
            return track?.Name ?? "N/A";
        }
    }
}
