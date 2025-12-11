<?php
$hoszt = 'mysql';
$db = 'tesztdb';
$felhasznalo = 'felhasznalo';
$pass = 'felhasznaloi_jelszo';

próbáld ki {
    $pdo = new PDO("mysql:host=$host;dbname=$db;charset=utf8", $user, $pass);
    echo "<h2>✅ Sikeres MySQL kapcsolat Apache + PHP-ből!</h2>";
} catch (PDOException $e) {
    echo "<h2>❌ Hiba:</h2>" . $e->getMessage();
}
?>