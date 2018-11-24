using System.ComponentModel;

namespace pkNX.Randomization
{
    public class TrainerRandSettings
    {
        private const string General = nameof(General);
        private const string Classes = nameof(Classes);
        private const string Pok�mon = nameof(Pok�mon);
        private const string Stats = nameof(Stats);
        private const string Moves = nameof(Moves);

        #region General
        [Category(General), Description("Minimum count of Pok�mon the Trainer has. New Pok�mon will be added to the team if less are currently present.")]
        public int TeamCountMin { get; set; }

        [Category(General), Description("Maximum count of Pok�mon the Trainer has. Pok�mon will be removed from the team if more are currently present.")]
        public int TeamCountMax { get; set; }

        [Category(General), Description("Chooses a random type for the Trainer, and requires each Pok�mon to have that type.")]
        public bool TeamTypeThemed { get; set; }

        [Category(General), Description("Maxes out the Trainer AI value to use its team and moves most effectively.")]
        public bool TrainerMaxAI { get; set; }

        [Category(General), Description("Force special strong battles to have a full team of 6 Pok�mon.")]
        public bool ForceSpecialTeamCount6 { get; set; }
        #endregion

        #region General
        [Category(Classes), Description("Change Trainer Class to another random Trainer Class.")]
        public bool RandomTrainerClass { get; set; }

        [Category(Classes), Description("Skip changing Trainer Classes that are considered special (avoiding crashes).")]
        public bool SkipSpecialClasses { get; set; }
        #endregion

        #region Pok�mon
        [Category(Pok�mon), Description("Randomizes the Species and basic stat details of all Team members.")]
        public bool RandomizeTeam { get; set; }

        [Category(Pok�mon), Description("Allows random Mega Forms when randomizing species.")]
        public bool AllowRandomMegaForms { get; set; }

        [Category(Pok�mon), Description("Forces all Pok�mon above the specified level setting to be fully evolved.")]
        public bool ForceFullyEvolved { get; set; }

        [Category(Pok�mon), Description("Forces all Pok�mon above this level to be fully evolved if the " + nameof(ForceFullyEvolved) + " setting is set.")]
        public int ForceFullyEvolvedAtLevel { get; set; }

        [Category(Pok�mon), Description("Causes all Pok�mon levels to be boosted by the specified ratio multiplier.")]
        public bool BoostLevel { get; set; }

        [Category(Pok�mon), Description("Boosts levels of all Pok�mon by this ratio if the " + nameof(BoostLevel) + "setting is set.")]
        public decimal LevelBoostRatio { get; set; }
        #endregion

        #region Stats
        [Category(Stats), Description("Makes random Trainer Pok�mon shiny.")]
        public bool RandomShinies { get; set; }

        [Category(Stats), Description("Makes random Trainer Pok�mon shiny at this rate.")]
        public decimal ShinyChance { get; set; }

        [Category(Stats), Description("Maximizes all IVs.")]
        public bool MaxIVs { get; set; }

        [Category(Stats), Description("Picks a random valid ability for each Pok�mon.")]
        public bool RandomAbilities { get; set; }
        #endregion

        #region Moves
        [Category(Moves), Description("Prevents Pok�mon movesets from containing fixed damage moves.")]
        public bool BanFixedDamageMoves { get; set; }

        [Category(Moves), Description("How movesets are randomized/chosen for each Pok�mon.")]
        public MoveRandType MoveRandType { get; set; }
        #endregion
    }
}