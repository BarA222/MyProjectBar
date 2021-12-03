using DAL.Model;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    /// <summary>
    /// Interface for meetings, add, update, delete and get all meetings
    /// </summary>
    public interface IMeetings
    {
        Task<Message> AddNewMeeting(int userId, int customerId, string meetingSubject, string description);

        Task<List<Meeting>> GetMeeting();
        Task<Message> DeleteMeeting(int meetingId);
        Task<Message> UpdateMeeting(Meeting meeting);
        Task<Meeting> GetMeetingByMeetingId(Meeting meetingId);
        Task<List<Meeting>> GetMeetingsForconsultant(int userId, DateTime date);
    }
}
