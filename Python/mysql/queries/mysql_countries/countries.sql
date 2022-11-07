-- #1
SELECT  countries.name,languages.language,languages.percentage FROM languages
JOIN countries ON countries.id=languages.country_id WHERE language="Slovene" 
ORDER BY percentage DESC;

-- #2
SELECT countries.name, COUNT(*) FROM cities
JOIN countries ON cities.country_id = countries.id
GROUP BY countries.name 
ORDER BY COUNT(*) DESC;

-- #3
SELECT cities.name, cities.population, countries.id  
FROM countries JOIN cities ON cities.country_id = countries.id
WHERE countries.name = "Mexico" AND cities.population>500000
ORDER BY cities.population DESC;

-- #4
SELECT countries.name, languages.language, languages.percentage
FROM languages JOIN countries ON countries.id = languages.country_id WHERE percentage>89
ORDER BY percentage DESC;

-- #5
SELECT countries.name, countries.surface_area, countries.population
FROM countries WHERE surface_area<501 AND population>100000;

-- #6
SELECT countries.name, countries.government_form, countries.capital, countries.life_expectancy
FROM countries WHERE capital>200 AND life_expectancy>75 AND government_form = "Constitutional Monarchy";

-- #7
SELECT countries.name, cities.name, cities.district, cities.population
FROM cities JOIN countries ON countries.id = cities.country_id WHERE countries.name = "Argentina" AND cities.district = "Buenos Aires" AND cities.population >500000;

-- #8
SELECT countries.region, COUNT(*) 
FROM countries GROUP BY region
ORDER BY COUNT(*) DESC;