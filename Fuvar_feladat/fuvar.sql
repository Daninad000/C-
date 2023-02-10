

/* 3. feladat */
SELECT COUNT(tax_id) as 'összes fuvar' FROM `fuvar`;

/* 4. feladat */
SELECT tax_id, COUNT(tax_id) as 'fuvarok száma', SUM(viteldij) as 'bevétel' FROM `fuvar` WHERE tax_id = 6185;

/* 5. feladat */
SELECT fizetes_modja AS 'fizetés módja', COUNT(fizetes_modja) AS 'hányszor fizettek' FROM fuvar 
/* WHERE fizetes_modja = 'bankkártya' OR fizetes_modja = 'készpénz' OR fizetes_modja = 'vitatott' OR fizetes_modja = 'ingyenes' OR fizetes_modja = 'ismeretlen'*/ 
GROUP BY(fizetes_modja);

/* 6. feladat */
SELECT ROUND(SUM(tavolsag*1.6),2) AS 'Taxisok összes megtett távolsága km-ben' FROM `fuvar`;

/* 7. feladat */
SELECT tax_id, idotartam, tavolsag, viteldij FROM `fuvar`
WHERE idotartam IN (SELECT MAX(idotartam) FROM fuvar);

/* 8. feladat */
SELECT * FROM `fuvar` 
WHERE idotartam > 0 AND viteldij > 0 AND tavolsag = 0
ORDER BY indulas;

