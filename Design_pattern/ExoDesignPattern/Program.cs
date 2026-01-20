//using FQ25L066_CorrectionGladiateur;
//using FQ25L066_CorrectionGladiateur.Patterns.Mediator;

//Logging logging = new Logging();

//Gladiateur tom = new("Tom");
//tom.IsDeadHandler += OnGladiateurIsDead;
//Gladiateur jerry = new("Jerry");
//jerry.IsDeadHandler += OnGladiateurIsDead;

//bool endGame = false;
////Détermine qui commence entre Tom et Jerry
//bool isTomTurn = Random.Shared.Next() % 2 == 0;

//while (!endGame)
//{
//    if (isTomTurn)
//        tom.Frappe(jerry);
//    else
//        jerry.Frappe(tom);

//    isTomTurn = !isTomTurn;
//}


//void OnGladiateurIsDead(Gladiateur gladiateur)
//{
//    gladiateur.IsDeadHandler -= OnGladiateurIsDead;
//    endGame = true;
//    Messenger<string>.Instance.Send($"{gladiateur.Nom} est mort!");
//}