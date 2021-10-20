using System;
using System.Collections.Generic;

namespace CollegeVS.Models.API.CVChallengePlugin
{
    public class CVChallengePlugin
    {

        public List<CVChallenge> CVChallengeList { get; set; }


    }
    public class CVChallenge
    {
        // These properties should be set upon the creation of the object.

        /// <summary>
        /// The title of the challenge
        /// </summary>
        public string ChallengeTitle { get; set; }

        /// <summary>
        /// The pluralized version of the title
        /// </summary>
        public string ChallengeTitlePluralized { get; set; }

        /// <summary>
        /// Holds static identifier for this challenge object
        /// </summary>
        public string ChallengeID { get; set; }

        /// <summary>
        /// The name that will be found in the databse for the challenge (deprecated?)
        /// </summary>
        public string ChallengeDBName { get; set; }

        /// <summary>
        /// A list of <see cref="Tier"/> objs for the given challenge
        /// </summary>
        public List<Tier> TierList { get; set; }

        /// <summary>
        /// String representation of the unit type that the user must achieve
        /// </summary>
        public string ChallengeUnit { get; set; }

        /// <summary>
        /// Pluralized string representation of the unit type that the user must achieve
        /// </summary>
        public string ChallengeUnitPlural { get; set; }

        /// <summary>
        /// The text to display for this challenge over its accolade
        /// </summary>
        public string AccoladeText { get; set; }

        /// <summary>
        /// Flag indicating whether or not to display on the front page
        /// </summary>
        public bool IsHidden { get; set; }

        public override string ToString()
        {
            return "Title: " + ChallengeTitle + Environment.NewLine +
                   "Challenge ID: " + ChallengeID + Environment.NewLine +
                   "Challenge db Name: " + ChallengeDBName + Environment.NewLine +
                   "TierList: " + String.Join(", ", TierList) + Environment.NewLine;
        }
    }

    public class Tier
    {
        /// <summary>
        /// The number that muched be reached to complete this tier
        /// </summary>
        public int TierInt { get; set; }

        /// <summary>
        /// Amount of points awarded when this tier is reached
        /// </summary>
        public int PointsAwarded { get; set; }


        public int Rank { get; set; }
    }
}
