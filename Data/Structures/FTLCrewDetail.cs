using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data
{
    class FTLCrewDetail : FTLContainer
    {
        public FTLString Name { get; private set; }
        public FTLString Race { get; private set; }
        public FTLInt IsDrone { get; private set; }
        public FTLInt Hp { get; private set; }
        public FTLInt XCoordinate { get; private set; }
        public FTLInt YCoordinate { get; private set; }
        public FTLInt Room { get; private set; }
        public FTLInt RoomTile { get; private set; }
        public FTLInt Piloting { get; private set; }
        public FTLInt Engines { get; private set; }
        public FTLInt Shields { get; private set; }
        public FTLInt Weapons { get; private set; }
        public FTLInt Repair { get; private set; }
        public FTLInt Combat { get; private set; }
        public FTLInt Gender { get; private set; }
        public FTLInt RepairsStat { get; private set; }
        public FTLInt CombatKillsStat { get; private set; }
        public FTLInt PilotedEvasionsStat { get; private set; }
        public FTLInt JumpsSurvivedStat { get; private set; }
        public FTLInt SkillMasteriesStat { get; private set; }
        public FTLInt Unknown { get; private set; }

        public FTLCrewDetail()
        {
            Name = new FTLString("Name");
            Race = new FTLString("Race");
            IsDrone = new FTLInt("Is Drone");
            Hp = new FTLInt("HP");
            XCoordinate = new FTLInt("X");
            YCoordinate = new FTLInt("Y");
            Room = new FTLInt("Room");
            RoomTile = new FTLInt("Room Tile");
            Piloting = new FTLInt("Piloting (0 - 30)");
            Engines = new FTLInt("Engines (0 - 30)");
            Shields = new FTLInt("Shields (0 - 110)");
            Weapons = new FTLInt("Weapons (0 - 130)");
            Repair = new FTLInt("Repair (0 -  16)");
            Combat = new FTLInt("Combat (0 - 16)");
            Gender = new FTLInt("Gender");
            RepairsStat = new FTLInt("Repairs (stat)");
            CombatKillsStat = new FTLInt("Combat Kills (stat)");
            PilotedEvasionsStat = new FTLInt("Piloted Evasions (stat)");
            JumpsSurvivedStat = new FTLInt("Jumps Survived (stat)");
            SkillMasteriesStat = new FTLInt("Skills Mastered (stat)");
            Unknown = new FTLInt("Unknown");
        }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Name;
            yield return Race;
            yield return IsDrone;
            yield return Hp;
            yield return XCoordinate;
            yield return YCoordinate;
            yield return Room;
            yield return RoomTile;
            yield return Piloting;
            yield return Engines;
            yield return Shields;
            yield return Weapons;
            yield return Repair;
            yield return Combat;
            yield return Gender;
            yield return RepairsStat;
            yield return CombatKillsStat;
            yield return PilotedEvasionsStat;
            yield return JumpsSurvivedStat;
            yield return SkillMasteriesStat;
            yield return Unknown;
        }
    }
}
