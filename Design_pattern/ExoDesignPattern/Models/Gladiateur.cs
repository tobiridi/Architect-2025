using ExoDesignPattern.Builder;
using FQ25L066_CorrectionGladiateur.Patterns.Mediator;
using FQ25L066_CorrectionGladiateur.Patterns.Observer;
using System.Xml.Linq;

namespace ExoDesignPattern.Models;

public class Gladiateur : ILifeStateChanged
{
    public event Action<Gladiateur>? IsDeadHandler;

    private int _pv;
    public string Nom { get; }
    public int Level { get; private set; }
    public bool IsDead { get; private set; }
    public string Username { get; private set; }
    public int NbArms { get; private set; }
    public DateTime createAt { get; private set; }

    public int PV
    {
        get
        {
            return _pv;
        }
        private set
        {
            _pv = value;
            if (_pv <= 0)
                IsDeadHandler?.Invoke(this);
        }
    }

    public Gladiateur(string nom)
    {
        Nom = nom;
        PV = 100;
    }

    public Gladiateur(string nom, int level, bool isDead, string username, int nbArms, DateTime createAt)
    {
        this.Nom = nom;
        this.Level = level;
        this.IsDead = isDead;
        this.Username = username;
        this.NbArms = nbArms;
        this.createAt = createAt;
    }

    public override string ToString()
    {
        return "Gladiateur : {" +
            $" nom : {this.Nom}," +
            $" level : {this.Level}," +
            $" isDead : {this.IsDead}," +
            $" username: {this.Username}," +
            $" nb arms : {this.NbArms}," +
            $" create at : {this.createAt}";
    }

    public void Frappe(Gladiateur cible)
    {
        int random = Random.Shared.Next(4) + 1;
        Messenger<string>.Instance.Send($"{Nom} frappe {cible.Nom} et lui inflige {random} point de dégats");
        //Retirer des PV sur base d'un random Random.Shared.Next(4)
        cible.PV -= random;
    }

    public class Builder: IGladiateurBuilder, IGladiateurName, IGladiateurLevel, IGladiateurIsDead, 
        IGladiateurUsername, IGladiateurArms, IGladiateurCreateDate
    {
        public string Nom { get; private set; }
        public int Level { get; private set; }
        public bool IsDead { get; private set; }
        public string Username { get; private set; }
        public int NbArms { get; private set; }
        public DateTime createAt { get; private set; }

        private Builder() {}

        public static IGladiateurBuilder Create()
        {
            return new Builder();
        }

        public Gladiateur Build()
        {
            return new Gladiateur(Nom, Level, IsDead, Username, NbArms, createAt);
        }

        public IGladiateurName WithName(string name)
        {
            this.Nom = name;
            return this;
        }

        public IGladiateurLevel WithLevel(int level)
        {
            this.Level = level;
            return this;
        }

        public IGladiateurIsDead SetDead()
        {
            this.IsDead = true;
            return this;
        }

        public IGladiateurCreateDate CreateAt(DateTime creation)
        {
            this.createAt = creation;
            return this;
        }

        public IGladiateurArms WithArms(int arms)
        {
            this.NbArms = arms;
            return this;
        }

        public IGladiateurUsername WithUsername(string username)
        {
            this.Username = username;
            return this;
        }

    }
}