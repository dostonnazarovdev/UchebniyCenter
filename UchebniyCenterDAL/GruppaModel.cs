using System;

namespace UchebniyCenterDAL
{
    public class GruppaModel : BaseModel
    {
        public string Name { get; set; }
        public string KursName { get; set; }
        public long? TeacherId { get; set; }
    
        public decimal? KursPrice { get; set; }

        public decimal? OneLessonsPrice { get; set; }

        public int? LessonsCount { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set;}

        public DateTime? StartTimeInADay { get; set; }

        public DateTime? EndTimeInADay { get; set; }

        public string DaysOfWeek { get; set; } //1010101 - пн,вт,ср,чт,пт,сб,вс

        public string Cabinet { get; set; }

        public GruppaState? gruppaState { get; set; } = GruppaState.NotActive;
    }

    public enum GruppaState
    {
        Active = 1,
        NotActive = 2,
        Finished = 3
    }
}
