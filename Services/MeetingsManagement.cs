using Contracts;
using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Meeting service business logic class, implements the IMeeting
    /// </summary>
    public class MeetingsManagement : IMeetings
    {
        private MeetingsRepository repo = new MeetingsRepository();
        public async Task<Message> AddNewMeeting(int userId, int customerId,  string meetingSubject, string description)
        {
            return await repo.AddMeetingAsync( userId,customerId, meetingSubject, description);
        }

        public async Task<Message> DeleteMeeting(int meetingId)
        {
            return await repo.DeleteMeetingAsync(meetingId);
        }

        public async Task<List<Meeting>> GetMeeting()
        {
           return await repo.GetMeetingAsync();
        }

        public async Task<Meeting> GetMeetingByMeetingId(Meeting meetingId)
        {
            return await repo.GetMeetingByMeetingIdAsync(meetingId);
        }

        public async Task<List<Meeting>> GetMeetingsForconsultant(int userId, DateTime date)
        {
            return await repo.GetMeetingsForconsultantAsync(userId, date);
        }

        public async Task<Message> UpdateMeeting(Meeting meeting)
        {
            return await repo.UpdateMeetingDetailsAsync(meeting);
        }
    }
}
