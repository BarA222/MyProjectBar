using DAL.DataAccess;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    /// <summary>
    /// This class allows add new meetings for existing customers, see their meetings, delete them and edit
    /// </summary>
    public class MeetingsRepository
    {
        ConsultantsManagementDbContext dbContext = new ConsultantsManagementDbContext();

        public async Task<Message> AddMeetingAsync(int userId, int customerId, string meetingSubject, string description)
        {
            try
            {
                var user = await dbContext.Users.Where(x => x.UserId == userId).FirstOrDefaultAsync();

                if (user == null)
                    return new Message { IsSuccess = false, Content = "User not exist" };

                var customer = await dbContext.Customers.Where(x => x.CustomerId == customerId).FirstOrDefaultAsync();

                if (customer == null)
                    return new Message { IsSuccess = false, Content = "Customer can't be null" };

                if (string.IsNullOrEmpty(meetingSubject))
                {
                    return new Message { IsSuccess = false, Content = "Subject can't be null" };
                }

                await dbContext.Meetings.AddAsync(new Model.Meeting
                {
                    Date = DateTime.Now.Date,
                    MeetingSubject = meetingSubject,
                    Description = description,
                    UserId = userId,
                    CustomerId = customerId
                });
                await dbContext.SaveChangesAsync();
                return new Message { IsSuccess = true, Content = "Meeting is added succefully" };
            }
            catch
            {
                return new Message { IsSuccess = false, Content = "Meeting can't be added" };
            }
        }
        public async Task<List<Meeting>> GetMeetingAsync()
        {
            try
            {
                using (var conn = new ConsultantsManagementDbContext())
                {
                    return await conn.Meetings.ToListAsync();
                }

            }
            catch
            {
                return new List<Meeting>();
            }
        }
        public async Task<List<Meeting>> GetMeetingsForconsultantAsync(int userId, DateTime date)
        {
            try
            {
                return await dbContext.Meetings.Where(m => m.UserId == userId && m.Date == date).ToListAsync();
            }
            catch
            {
                return new List<Meeting>();
            }
        }

        public async Task<Message> DeleteMeetingAsync(int meetingId)
        {
            try
            {
                var meeting = await dbContext.Meetings.Where(m => m.MeetingId == meetingId).FirstOrDefaultAsync();

                if (meeting == null)
                    return new Message { IsSuccess = false, Content = "Meeting can't be deleted" };

                dbContext.Meetings.Remove(meeting);
                await dbContext.SaveChangesAsync();
                return new Message { IsSuccess = true, Content = "Meeting deleted successfully " };
            }
            catch
            {
                return new Message { IsSuccess = false, Content = "Meeting can't be deleted" };
            }
        }


        public async Task<Message> UpdateMeetingDetailsAsync(Meeting meeting)
        {
            try
            {
                using (var conn = new ConsultantsManagementDbContext())
                {
                    var meetingDB = await conn.Meetings.Where(x => x.MeetingId == meeting.MeetingId).FirstOrDefaultAsync();


                    if (meetingDB == null)
                        return new Message { IsSuccess = false, Content = "Meeting is not found" };

                    if (!string.IsNullOrEmpty(meeting.Description) && !meeting.Description.Equals(meetingDB.Description))
                        meetingDB.UpdateDescription(meeting.Description);

                    if (!string.IsNullOrEmpty(meeting.MeetingSubject) && !meeting.MeetingSubject.Equals(meetingDB.MeetingSubject))
                    {
                        meetingDB.UpdateSubject(meeting.MeetingSubject);
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(meeting.MeetingSubject))
                            return new Message { IsSuccess = false, Content = "Subject is required" };
                    }

                    if (DateTime.Now.Date > meeting.Date.Date)
                        return new Message { IsSuccess = false, Content = "Invalid date, date must be greater than today" };
                    else
                    {

                        if (DateTime.Now.Date <= meeting.Date.Date)
                            meetingDB.UpdateDate(meeting.Date);
                    }

                    if (meeting.UserId != 0)
                    {
                        var user = await conn.Users.Where(x => x.UserId == meeting.UserId).FirstOrDefaultAsync();

                        if (user == null)
                            return new Message { IsSuccess = false, Content = "User is required" };

                        meetingDB.UpdateUser(user);
                    }

                    conn.Meetings.Update(meetingDB);
                    await conn.SaveChangesAsync();
                    return new Message { IsSuccess = true, Content = "Meeting is updated succefully " };
                }
            }
            catch
            {
                return new Message { IsSuccess = false, Content = "Can't update the meeting" };
            }
        }

        public async Task<Meeting> GetMeetingByMeetingIdAsync(Meeting meetingId)
        {
            try
            {
                return await dbContext.Meetings.FindAsync(meetingId.MeetingId);
            }
            catch
            {
                return null;
            }
        }



    }
}
