<div dir='rtl' lang='he'>

# MyDoodleJump

קישור למשחק : https://talabed.itch.io/my-doodle-jump

המשחק בנוי מ2 שלבים:
* בשלב הראשון על השחקן להיגע למדרגה האחרונה מבלי שדבר מפריע לו
* בשלב השני על השחקן להגיע למדרגה האחרונה תוך שהוא מתחמק מרובוטים היורדים מלמעלה

בעזרת שימוש ברכיבים פיזיקליים וסקריפטים מתאימים השחקן יכול לטפס במעלה המדרגות.

השחקן מת בכל פעם שהוא:
* נפגע מרובוט
* נופל למטה
* יוצא מגבולות המסך

## רכיבים:

* Player - דמות השחקן, נע על ידי סקריפט PlayerMover
* Ramp - המשטח עליו נוחת השחקן. בעזרת סקריפט Ramp ושימוש בEdgeCollide2D וPlatformEffector2D גורם לשחקן לקפוץ עליו בכוח קבוע (ניתן לשינוי).
* Enemy - האויב של השחקן. בעזרת סקריפט StartOver מחזיר את השחקן לתחילת השלב אם הוא פוגע בו.
* EnemySpawner - רכיב השולח רובוטים בצורה רנדומלית בעזרת סקריפט TimedSpawnerRandom

## רעיונות להמשך המשחק:

* מדרגה נעלמת לאחר שהשחקן קופץ עליה פעם אחת
* ניקוד לפי מספר המדרגות שעבר השחקן
* להטיל על השחקן לאסוף חפצים מסוימים בדרך
* מדרגות מיוחדות - מקפיצות יותר גבו, נעלמות וחוזרות ועוד

<div>
