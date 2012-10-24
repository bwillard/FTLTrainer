using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            Name = new FTLString();
            Race = new FTLString();
            IsDrone = new FTLInt();
            Hp = new FTLInt();
            XCoordinate = new FTLInt();
            YCoordinate = new FTLInt();
            Room = new FTLInt();
            RoomTile = new FTLInt();
            Piloting = new FTLInt();
            Engines = new FTLInt();
            Shields = new FTLInt();
            Weapons = new FTLInt();
            Repair = new FTLInt();
            Combat = new FTLInt();
            Gender = new FTLInt();
            RepairsStat = new FTLInt();
            CombatKillsStat = new FTLInt();
            PilotedEvasionsStat = new FTLInt();
            JumpsSurvivedStat = new FTLInt();
            SkillMasteriesStat = new FTLInt();
            Unknown = new FTLInt();
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
