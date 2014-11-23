﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EatSmart.Services
{
    public class FoodsForTargetFetcherService
    {
        public IEnumerable<string> HighCalories()
        {
            return new List<string>()
            {
                "Fat, beef tallow (902)",
"Fat, mutton tallow (902)",
"Fish oil, cod liver (902)",
"Fish oil, herring (902)",
"Fish oil, menhaden (902)",
"Fish oil, menhaden, fully hydrogenated (902)",
"Fish oil, salmon (902)",
"Fish oil, sardine (902)",
"Lard (902)",
"Fat, chicken (900)",
"Fat, goose (900)",
"Fat, turkey (900)",
"Oil, beluga, whale (Alaska Native) (900)",
"Oil, walrus (Alaska Native) (900)",
"Oil, whale, bowhead (Alaska Native) (900)",
"Shortening frying (heavy duty), beef tallow and cottonseed (900)",
"Shortening industrial, lard and vegetable oil (900)",
"Shortening, household, lard and vegetable oil (900)",
"Oil, bearded seal (Oogruk) (Alaska Native) (899)",
"Pork, bacon, rendered fat, cooked [bacon drippings] (898)",
"Animal fat, bacon grease (896)",
"Oil, spotted seal (Alaska Native) (894)",
"Shortening, institutional, composite (894)",
"Meat drippings (lard, beef tallow, mutton tallow) (889)",
"Flaxseed oil (884)",
"Oil, cooking and salad, ENOVA, 80% diglycerides (884)",
"Oil, corn and canola (884)",
"Oil, corn, peanut, and olive (884)",
"Oil, industrial, canola with antifoaming agent, principal uses salads, woks and light frying (884)",
"Oil, industrial, coconut, principal uses candy coatings, oil sprays, roasting nuts (884)",
"Oil, industrial, palm kernel (hydrogenated), filling fat (884)",
"Oil, industrial, soy (partially hydrogenated) and cottonseed, principal use as a tortilla shortening (884)",
"Oil, olive, salad or cooking (884)",
"Oil, peanut, salad or cooking (884)",
"Oil, sesame, salad or cooking (884)",
"Oil, soybean, salad or cooking (884)",
"Oil, soybean, salad or cooking, (hydrogenated) and cottonseed (884)",
"Oil, soybean, salad or cooking, (partially hydrogenated) (884)",
"Oil, vegetable safflower, salad or cooking, linoleic, (over 70%) (884)",
"Oil, vegetable safflower, salad or cooking, oleic, over 70% (primary safflower oil of commerce) (884)",
"Oil, vegetable, almond (884)",
"Oil, vegetable, apricot kernel (884)",
"Oil, vegetable, babassu (884)",
"Oil, vegetable, canola [low erucic acid rapeseed oil] (884)",
"Oil, vegetable, cocoa butter (884)",
"Oil, vegetable, corn, industrial and retail, all purpose salad or cooking (884)",
"Oil, vegetable, cottonseed, salad or cooking (884)",
"Oil, vegetable, cupu assu (884)",
"Oil, vegetable, grapeseed (884)",
"Oil, vegetable, hazelnut (884)"
            };
        }

        public IEnumerable<string> HighCarbohydrates()
        {
            return new List<string>()
            {
                "Cold Stone Creamery dessert: Mix-In, Gumballs (120g)",
"Cold Stone Creamery dessert: Mix-In, Gummi Bears (106g)",
"Sweeteners, tabletop, fructose, dry, powder (100g)",
"Sugars, granulated [sucrose] (100g)",
"Sugars, powdered (100g)",
"Strawberry-flavor beverage mix, powder (99g)",
"Desserts, rennin, vanilla, dry mix (99g)",
"Orange-flavor drink, breakfast type, powder (99g)",
"Candies, gumdrops, starch jelly pieces (99g)",
"Apple cider-flavored drink, powder, added vitamin C and sugar (99g)",
"Tea, instant, sweetened with sugar, lemon-flavored, without added ascorbic acid, powder (99g)",
"Tea, instant, sweetened with sugar, lemon-flavored, without added ascorbic acid, powder, decaffeinated (99g)",
"Sugars, brown (98g)",
"Candies, hard (98g)",
"Fruit punch-flavor drink, powder, without added sodium (98g)",
"Tea, instant, sweetened with sugar, lemon-flavored, with added ascorbic acid, powder (98g)",
"Whiskey sour mix, powder (97g)",
"Puddings, lemon, dry mix, instant (95g)",
"Drink mix, QUAKER OATS, GATORADE, lemon-lime flavor, powder (95g)",
"Frostings, white, fluffy, dry mix (95g)",
"Chewing gum, sugarless (95g)",
"Lemonade, powder (94g)",
"Lemonade-flavor drink, powder (94g)",
"Puddings, tapioca, dry mix (94g)",
"Puddings, tapioca, dry mix, with no added salt (94g)",
"Drink mix, QUAKER OATS, GATORADE, orange flavor, powder (94g)",
"Frostings, vanilla, creamy, dry mix (94g)",
"Cereals ready-to-eat, MALT-O-MEAL, CORN BURSTS (94g)",
"Apples, dehydrated (low moisture), sulfured, uncooked (94g)",
"Candies, jellybeans (94g)",
"Puddings, vanilla, dry mix, regular (94g)",
"Candies, hard, dietetic or low calorie (sorbitol) (93g)",
"Carob-flavor beverage mix, powder (93g)",
"Candies, fondant, prepared-from-recipe (93g)",
"Puddings, banana, dry mix, regular (93g)",
"Puddings, vanilla, dry mix, instant (93g)",
"Puddings, banana, dry mix, instant (93g)",
"Puddings, vanilla, dry mix, regular, with added oil (92g)",
"Candies, nougat, with almonds (92g)",
"Frostings, chocolate, creamy, dry mix (92g)",
"Puddings, lemon, dry mix, regular (92g)",
"Flan, caramel custard, dry mix (92g)",
"Candies, taffy, prepared-from-recipe (92g)",
"Desserts, rennin, chocolate, dry mix (91g)",
"Fruit-flavored drink mix, powder, unsweetened (91g)",
"Cornstarch (91g)",
"Puddings, coconut cream, dry mix, instant (91g)",
"Puddings, rice, dry mix (91g)",
"Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (91g)",
"Candies, MASTERFOODS USA, SKITTLES Wild Berry Bite Size Candies (91g)"
            };
        }

        public IEnumerable<string> HighFat()
        {
            return new List<string>()
            {
                "Fat, beef tallow (100g)",
"Fat, mutton tallow (100g)",
"Fish oil, cod liver (100g)",
"Fish oil, herring (100g)",
"Fish oil, menhaden (100g)",
"Fish oil, menhaden, fully hydrogenated (100g)",
"Fish oil, salmon (100g)",
"Fish oil, sardine (100g)",
"Flaxseed oil (100g)",
"Lard (100g)",
"Oil, beluga, whale (Alaska Native) (100g)",
"Oil, cooking and salad, ENOVA, 80% diglycerides (100g)",
"Oil, corn and canola (100g)",
"Oil, corn, peanut, and olive (100g)",
"Oil, industrial, canola with antifoaming agent, principal uses salads, woks and light frying (100g)",
"Oil, industrial, coconut, principal uses candy coatings, oil sprays, roasting nuts (100g)",
"Oil, industrial, palm kernel (hydrogenated), filling fat (100g)",
"Oil, industrial, soy (partially hydrogenated) and cottonseed, principal use as a tortilla shortening (100g)",
"Oil, olive, salad or cooking (100g)",
"Oil, peanut, salad or cooking (100g)",
"Oil, sesame, salad or cooking (100g)",
"Oil, soybean, salad or cooking (100g)",
"Oil, soybean, salad or cooking, (hydrogenated) and cottonseed (100g)",
"Oil, soybean, salad or cooking, (partially hydrogenated) (100g)",
"Oil, vegetable safflower, salad or cooking, linoleic, (over 70%) (100g)",
"Oil, vegetable safflower, salad or cooking, oleic, over 70% (primary safflower oil of commerce) (100g)",
"Oil, vegetable, almond (100g)",
"Oil, vegetable, apricot kernel (100g)",
"Oil, vegetable, babassu (100g)",
"Oil, vegetable, canola [low erucic acid rapeseed oil] (100g)",
"Oil, vegetable, cocoa butter (100g)",
"Oil, vegetable, corn, industrial and retail, all purpose salad or cooking (100g)",
"Oil, vegetable, cottonseed, salad or cooking (100g)",
"Oil, vegetable, cupu assu (100g)",
"Oil, vegetable, grapeseed (100g)",
"Oil, vegetable, hazelnut (100g)",
"Oil, vegetable, industrial, canola (partially hydrogenated) oil for deep fat frying (100g)",
"Oil, vegetable, industrial, canola for salads, woks and light frying (100g)",
"Oil, vegetable, industrial, coconut, confection fat, typical basis for ice cream coatings (100g)",
"Oil, vegetable, industrial, mid-oleic, sunflower, principal uses frying and salad dressings [NuSun] (100g)",
"Oil, vegetable, industrial, palm kernel (hydrogenated) , used for whipped toppings, non-dairy (100g)",
"Oil, vegetable, industrial, palm kernel (hydrogenated), confection fat, intermediate grade product (100g)",
"Oil, vegetable, industrial, palm kernel (hydrogenated), confection fat, uses similar to 95 degree hard butter (100g)",
"Oil, vegetable, industrial, palm kernel, confection fat, uses similar to high quality cocoa butter (100g)",
"Oil, vegetable, industrial, soy ( partially hydrogenated), all purpose (100g)",
"Oil, vegetable, industrial, soy (partially hydrogenated ) and soy (winterized), pourable clear fry (100g)",
"Oil, vegetable, industrial, soy (partially hydrogenated ), palm, principal uses icings and fillings (100g)",
"Oil, vegetable, industrial, soy (partially hydrogenated), multiuse for non-dairy butter flavor (100g)",
"Oil, vegetable, industrial, soy (partially hydrogenated), principal uses popcorn and flavoring vegetables (100g)",
"Oil, vegetable, industrial, soy, refined, for woks and light frying (100g)"
            };
        }

        public IEnumerable<string> LowCalories()
        {
            return new List<string>()
            {
                "A&W beverage: Diet Root Beer (0)",
"Burger King beverage: Diet Coke® (0)",
"Carbonated beverage, club soda [soft drink] (0)",
"Carbonated beverage, low calorie, cola or pepper-types, with sodium saccharin, contains caffeine [pop, soda, soft drink] (0)",
"Carbonated beverage, low calorie, other than cola or pepper, without caffeine [pop, soda, soft drink] (0)",
"Carbonated beverage, low calorie, other than cola or pepper, with aspartame, contains caffeine [pop, soda, soft drink] (0)",
"Carbonated beverage, low calorie, other than cola or pepper, with sodium saccharin, without caffeine [pop, soda, soft drink] (0)",
"Carl's Jr. beverage: Diet Coke® (0)",
"Coffee, brewed from grounds, prepared with tap water, decaffeinated (0)",
"Coffee, brewed, espresso, restaurant-prepared, decaffeinated (0)",
"Culver's condiment: Mustard, Mild (0)",
"Culver's condiment: Mustard, Spicy Brown (0)",
"Del Taco taco: Coffee (0)",
"Hardee's condiment: Hot Sauce Packet (0)",
"Leavening agents, baking soda (0)",
"McDonald's beverage: Diet Coke® (0)",
"McDonald's beverage: Iced Tea (0)",
"Salt, table (0)",
"Starbucks addition: Flavored Sugar Free Syrup (0)",
"Taco Bell condiment: Border Sauce, fire (0)",
"Taco Bell condiment: Border Sauce, hot (0)",
"Taco Bell condiment: Border Sauce, mild (0)",
"Taco Bell condiment: Picante Sauce (0)",
"Water, bottled, generic (0)",
"Water, bottled, non-carbonated, CALISTOGA (0)",
"Water, bottled, non-carbonated, CRYSTAL GEYSER (0)",
"Water, bottled, non-carbonated, DANNON (0)",
"Water, bottled, non-carbonated, DANNON Fluoride To Go (0)",
"Water, bottled, non-carbonated, DASANI (0)",
"Water, bottled, non-carbonated, EVIAN (0)",
"Water, bottled, non-carbonated, NAYA (0)",
"Water, bottled, non-carbonated, PEPSI, AQUAFINA (0)",
"Water, bottled, PERRIER (0)",
"Water, bottled, POLAND SPRING (0)",
"Water, tap, drinking (0)",
"Water, tap, municipal (0)",
"Water, tap, well (0)",
"Wendy's beverage: Diet Cola Soft Drink (0)",
"Wienerschnitzel beverage: Diet Pepsi (0)",
"Carl's Jr. beverage: Coffee (1)",
"Apple cider-flavored drink, powder, low calorie, with vitamin C, prepared (1)",
"Carbonated beverage, low calorie, cola or pepper-type, with aspartame, without caffeine [pop, soda, soft drink] (1)",
"Coffee, brewed from grounds, prepared with tap water (1)",
"Tea, brewed, prepared with distilled water [black tea] (1)",
"Tea, brewed, prepared with tap water [black tea] (1)",
"Tea, brewed, prepared with tap water, decaffeinated [black tea] (1)",
"Tea, herb, chamomile, brewed (1)",
"Tea, herb, other than chamomile, brewed (1)",
"Tea, instant, unsweetened, powder, prepared (1)",
"Tea, ready-to-drink, unsweetened, WENDY'S, fast food, without ice (1)"
            };
        }

        public IEnumerable<string> LowCarbohydrates()
        {
            return new List<string>()
            {
                "A&W beverage: Diet Root Beer (0)",
"Burger King beverage: Diet Coke® (0)",
"Carbonated beverage, club soda [soft drink] (0)",
"Carbonated beverage, low calorie, cola or pepper-types, with sodium saccharin, contains caffeine [pop, soda, soft drink] (0)",
"Carbonated beverage, low calorie, other than cola or pepper, without caffeine [pop, soda, soft drink] (0)",
"Carbonated beverage, low calorie, other than cola or pepper, with aspartame, contains caffeine [pop, soda, soft drink] (0)",
"Carbonated beverage, low calorie, other than cola or pepper, with sodium saccharin, without caffeine [pop, soda, soft drink] (0)",
"Carl's Jr. beverage: Diet Coke® (0)",
"Coffee, brewed from grounds, prepared with tap water, decaffeinated (0)",
"Coffee, brewed, espresso, restaurant-prepared, decaffeinated (0)",
"Culver's condiment: Mustard, Mild (0)",
"Culver's condiment: Mustard, Spicy Brown (0)",
"Del Taco taco: Coffee (0)",
"Hardee's condiment: Hot Sauce Packet (0)",
"Leavening agents, baking soda (0)",
"McDonald's beverage: Diet Coke® (0)",
"McDonald's beverage: Iced Tea (0)",
"Salt, table (0)",
"Starbucks addition: Flavored Sugar Free Syrup (0)",
"Taco Bell condiment: Border Sauce, fire (0)",
"Taco Bell condiment: Border Sauce, hot (0)",
"Taco Bell condiment: Border Sauce, mild (0)",
"Taco Bell condiment: Picante Sauce (0)",
"Water, bottled, generic (0)",
"Water, bottled, non-carbonated, CALISTOGA (0)",
"Water, bottled, non-carbonated, CRYSTAL GEYSER (0)",
"Water, bottled, non-carbonated, DANNON (0)",
"Water, bottled, non-carbonated, DANNON Fluoride To Go (0)",
"Water, bottled, non-carbonated, DASANI (0)",
"Water, bottled, non-carbonated, EVIAN (0)",
"Water, bottled, non-carbonated, NAYA (0)",
"Water, bottled, non-carbonated, PEPSI, AQUAFINA (0)",
"Water, bottled, PERRIER (0)",
"Water, bottled, POLAND SPRING (0)",
"Water, tap, drinking (0)",
"Water, tap, municipal (0)",
"Water, tap, well (0)",
"Wendy's beverage: Diet Cola Soft Drink (0)",
"Wienerschnitzel beverage: Diet Pepsi (0)",
"Carl's Jr. beverage: Coffee (1)",
"Apple cider-flavored drink, powder, low calorie, with vitamin C, prepared (1)",
"Carbonated beverage, low calorie, cola or pepper-type, with aspartame, without caffeine [pop, soda, soft drink] (1)",
"Coffee, brewed from grounds, prepared with tap water (1)",
"Tea, brewed, prepared with distilled water [black tea] (1)",
"Tea, brewed, prepared with tap water [black tea] (1)",
"Tea, brewed, prepared with tap water, decaffeinated [black tea] (1)",
"Tea, herb, chamomile, brewed (1)",
"Tea, herb, other than chamomile, brewed (1)",
"Tea, instant, unsweetened, powder, prepared (1)",
"Tea, ready-to-drink, unsweetened, WENDY'S, fast food, without ice (1)"
            };
        }

        public IEnumerable<string> LowFat()
        {
            return new List<string>()
            {
                "A&W beverage: Diet Root Beer (0g)",
"A&W beverage: Regular Root Beer (0g)",
"Alcoholic beverage, beer, light (0g)",
"Alcoholic beverage, beer, light, BUD LIGHT (0g)",
"Alcoholic beverage, beer, light, BUDWEISER SELECT (0g)",
"Alcoholic beverage, beer, light, MICHELOB ULTRA (0g)",
"Alcoholic beverage, beer, regular, all (0g)",
"Alcoholic beverage, beer, regular, BUDWEISER (0g)",
"Alcoholic beverage, daiquiri, canned (0g)",
"Alcoholic beverage, distilled, all (gin, rum, vodka, whiskey) 100 proof (0g)",
"Alcoholic beverage, distilled, all (gin, rum, vodka, whiskey) 80 proof (0g)",
"Alcoholic beverage, distilled, all (gin, rum, vodka, whiskey) 86 proof (0g)",
"Alcoholic beverage, distilled, all (gin, rum, vodka, whiskey) 90 proof (0g)",
"Alcoholic beverage, distilled, all (gin, rum, vodka, whiskey) 94 proof (0g)",
"Alcoholic beverage, distilled, gin, 90 proof (0g)",
"Alcoholic beverage, distilled, rum, 80 proof (0g)",
"Alcoholic beverage, distilled, vodka, 80 proof (0g)",
"Alcoholic beverage, distilled, whiskey, 86 proof (0g)",
"Alcoholic beverage, rice (sake) (0g)",
"Alcoholic beverage, whiskey sour, canned (0g)",
"Alcoholic beverage, whiskey sour, prepared from item 14530 (0g)",
"Alcoholic beverage, wine, cooking (0g)",
"Alcoholic beverage, wine, dessert, dry (0g)",
"Alcoholic beverage, wine, dessert, sweet (0g)",
"Alcoholic beverage, wine, light (0g)",
"Alcoholic beverage, wine, table, all (0g)",
"Alcoholic beverage, wine, table, red (0g)",
"Alcoholic Beverage, wine, table, red, Barbera (0g)",
"Alcoholic Beverage, wine, table, red, Burgundy (0g)",
"Alcoholic Beverage, wine, table, red, Cabernet Franc (0g)",
"Alcoholic Beverage, wine, table, red, Cabernet Sauvignon (0g)",
"Alcoholic Beverage, wine, table, red, Carignane (0g)",
"Alcoholic Beverage, wine, table, red, Claret (0g)",
"Alcoholic Beverage, wine, table, red, Gamay (0g)",
"Alcoholic Beverage, wine, table, red, Lemberger (0g)",
"Alcoholic Beverage, wine, table, red, Merlot (0g)",
"Alcoholic Beverage, wine, table, red, Mouvedre (0g)",
"Alcoholic Beverage, wine, table, red, Petite Sirah (0g)",
"Alcoholic Beverage, wine, table, red, Pinot Noir (0g)",
"Alcoholic Beverage, wine, table, red, Sangiovese (0g)",
"Alcoholic Beverage, wine, table, red, Syrah (0g)",
"Alcoholic Beverage, wine, table, red, Zinfandel (0g)",
"Alcoholic beverage, wine, table, white (0g)",
"Alcoholic beverage, wine, table, white, Chenin Blanc (0g)",
"Alcoholic beverage, wine, table, white, Fume Blanc (0g)",
"Alcoholic beverage, wine, table, white, Gewurztraminer (0g)",
"Alcoholic beverage, wine, table, white, late harvest (0g)",
"Alcoholic beverage, wine, table, white, Muller Thurgau (0g)",
"Alcoholic beverage, wine, table, white, Muscat (0g)",
"Alcoholic beverage, wine, table, white, Pinot Blanc (0g)"
            };
        }

        public IEnumerable<string> OptimumHealth()
        {
            return new List<string>()
            {
                "Basil, fresh ",
"Taro leaves, cooked, steamed, without salt ",
"Spices, basil, dried ",
"Asparagus, frozen, unprepared ",
"Horseradish-tree leafy tips, raw ",
"Dock, raw ",
"Alfalfa seeds, sprouted, raw ",
"Turnip greens, frozen, unprepared ",
"Dock, cooked, boiled, drained, without salt ",
"Spices, chervil, dried ",
"Kale, frozen, unprepared ",
"Squash, zucchini, baby, raw ",
"Mustard greens, cooked, boiled, drained, without salt ",
"Jute, potherb, cooked, boiled, drained, without salt ",
"Turnip greens and turnips, frozen, unprepared ",
"Chives, freeze-dried ",
"Sweet potato leaves, raw [Sweetpotato leaves] ",
"Lambsquarters, raw ",
"Collards, cooked, boiled, drained, without salt ",
"Horseradish-tree, leafy tips, cooked, boiled, drained, without salt ",
"Turnip greens, frozen, cooked, boiled, drained, without salt ",
"Pokeberry shoots, (poke), raw ",
"Celtuce, raw ",
"Broccoli raab, raw [Broccoli rabe, Rapini] ",
"Kale, raw ",
"Mustard spinach, (tendergreen), raw ",
"Spearmint, fresh [mint] ",
"Mustard spinach, (tendergreen), cooked, boiled, drained, without salt ",
"Peppermint, fresh [mint] ",
"Broccoli raab, cooked [Broccoli rabe, Rapini] ",
"Asparagus, frozen, cooked, boiled, drained, without salt ",
"Turnip greens and turnips, frozen, cooked, boiled, drained, without salt ",
"Mustard greens, frozen, unprepared ",
"Lambsquarters, steamed (Northern Plains Indians) ",
"Collards, frozen, chopped, unprepared ",
"Asparagus, raw ",
"Squash, summer, crookneck and straightneck, raw ",
"Squash, summer, crookneck and straightneck, frozen, unprepared ",
"Okra, raw ",
"Malabar spinach, cooked ",
"Thyme, fresh ",
"Lambsquarters, cooked, boiled, drained, without salt ",
"Spices, marjoram, dried ",
"Brussels sprouts, frozen, unprepared ",
"Spinach, canned, drained solids ",
"Taro leaves, raw ",
"Cabbage, chinese (pe-tsai), cooked, boiled, drained, without salt ",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN WITH EXTRA FIBER ",
"Beans, snap, yellow, raw ",
"Balsam-pear (bitter gourd), leafy tips, cooked, boiled, drained, without salt "
            };
        }

        public IEnumerable<string> WeightLoss()
        {
            return new List<string>()
            {
                "Basil, fresh ",
"Taro leaves, cooked, steamed, without salt ",
"Spices, basil, dried ",
"Asparagus, frozen, unprepared ",
"Horseradish-tree leafy tips, raw ",
"Dock, raw ",
"Alfalfa seeds, sprouted, raw ",
"Turnip greens, frozen, unprepared ",
"Dock, cooked, boiled, drained, without salt ",
"Spices, chervil, dried ",
"Kale, frozen, unprepared ",
"Squash, zucchini, baby, raw ",
"Mustard greens, cooked, boiled, drained, without salt ",
"Jute, potherb, cooked, boiled, drained, without salt ",
"Turnip greens and turnips, frozen, unprepared ",
"Chives, freeze-dried ",
"Sweet potato leaves, raw [Sweetpotato leaves] ",
"Lambsquarters, raw ",
"Collards, cooked, boiled, drained, without salt ",
"Horseradish-tree, leafy tips, cooked, boiled, drained, without salt ",
"Turnip greens, frozen, cooked, boiled, drained, without salt ",
"Pokeberry shoots, (poke), raw ",
"Celtuce, raw ",
"Broccoli raab, raw [Broccoli rabe, Rapini] ",
"Kale, raw ",
"Mustard spinach, (tendergreen), raw ",
"Spearmint, fresh [mint] ",
"Mustard spinach, (tendergreen), cooked, boiled, drained, without salt ",
"Peppermint, fresh [mint] ",
"Broccoli raab, cooked [Broccoli rabe, Rapini] ",
"Asparagus, frozen, cooked, boiled, drained, without salt ",
"Turnip greens and turnips, frozen, cooked, boiled, drained, without salt ",
"Mustard greens, frozen, unprepared ",
"Lambsquarters, steamed (Northern Plains Indians) ",
"Collards, frozen, chopped, unprepared ",
"Asparagus, raw ",
"Squash, summer, crookneck and straightneck, raw ",
"Squash, summer, crookneck and straightneck, frozen, unprepared ",
"Okra, raw ",
"Malabar spinach, cooked ",
"Thyme, fresh ",
"Lambsquarters, cooked, boiled, drained, without salt ",
"Spices, marjoram, dried ",
"Brussels sprouts, frozen, unprepared ",
"Spinach, canned, drained solids ",
"Taro leaves, raw ",
"Cabbage, chinese (pe-tsai), cooked, boiled, drained, without salt ",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN WITH EXTRA FIBER ",
"Beans, snap, yellow, raw ",
"Balsam-pear (bitter gourd), leafy tips, cooked, boiled, drained, without salt "
            };
        }

        public IEnumerable<string> WeightGain()
        {
            return new List<string>()
            {
                "Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (1.6  ND Rating: 4.4)",
"Cereals ready-to-eat, GENERAL MILLS, TOTAL Corn Flakes (1.6  ND Rating: 4.3)",
"Cereals, CREAM OF WHEAT, instant, dry (1.8  ND Rating: 4.5)",
"Orange-flavor drink, breakfast type, low calorie, powder (1.8  ND Rating: 4.4)",
"Cereals ready-to-eat, GENERAL MILLS, KIX (1.9  ND Rating: 4.6)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (1.9  ND Rating: 4.6)",
"Shallots, freeze-dried (1.9  ND Rating: 4.6)",
"Cereals ready-to-eat, GENERAL MILLS, CHEERIOS (2  ND Rating: 5)",
"Cereals ready-to-eat, MALT-O-MEAL, TOOTIE FRUITIES (1.5  ND Rating: 4.1)",
"Cereals ready-to-eat, GENERAL MILLS, Multi-Grain Cheerios (1.9  ND Rating: 4.5)",
"Cereals ready-to-eat, GENERAL MILLS, Country Corn Flakes (1.7  ND Rating: 4.2)",
"Cereals ready-to-eat, MALT-O-MEAL, Apple ZINGS (1.5  ND Rating: 4)",
"Cereals ready-to-eat, GENERAL MILLS, GENERAL MILLS Berry Burst CHEERIOS, all flavors (1.9  ND Rating: 4.5)",
"Formulated bar, POWER BAR, chocolate (2  ND Rating: 4.7)",
"Cereals ready-to-eat, Ralston TASTEEOS [Includes USDA Commodity B853] (2  ND Rating: 4.6)",
"Cereals ready-to-eat, MALT-O-MEAL, Honey Nut TOASTY O'S Cereal (1.8  ND Rating: 4.2)",
"Malted drink mix, chocolate, with added nutrients, powder (1.6  ND Rating: 4)",
"Cereals, MAYPO, dry (2.1  ND Rating: 4.9)",
"Cereals ready-to-eat, GENERAL MILLS, HARMONY (1.9  ND Rating: 4.4)",
"Cereals ready-to-eat, GENERAL MILLS, CHEERIOS, Yogurt Burst (1.7  ND Rating: 4.1)",
"Cereals, oats, instant, fortified, plain, dry [instant oatmeal] (2.1  ND Rating: 4.8)",
"Cereals ready-to-eat, MALT-O-MEAL, MARSHMALLOW MATEYS (1.7  ND Rating: 4.1)",
"Cereals, QUAKER, Instant Oatmeal, low sodium, dry (2.1  ND Rating: 4.8)",
"Cereals ready-to-eat, GENERAL MILLS, Team CHEERIOS (1.8  ND Rating: 4.2)",
"Malted drink mix, natural, with added nutrients, powder (1.8  ND Rating: 4.2)",
"Cereals ready-to-eat, WAFFELOS (1.5  ND Rating: 3.9)",
"Cereals ready-to-eat, MALT-O-MEAL, Apple Cinnamon TOASTY O's (1.7  ND Rating: 4.1)",
"Cereals ready-to-eat, GENERAL MILLS, CINNAMON TOAST CRUNCH (1.5  ND Rating: 3.9)",
"Cereals ready-to-eat, MALT-O-MEAL, Blueberry Muffin Tops Cereal (1.5  ND Rating: 3.9)",
"Spices, saffron (2  ND Rating: 4.4)",
"Cereals ready-to-eat, GENERAL MILLS, APPLE CINNAMON CHEERIOS (1.6  ND Rating: 3.9)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S PRODUCT 19 (1.7  ND Rating: 4)",
"Cereals ready-to-eat, GENERAL MILLS, LUCKY CHARMS (1.6  ND Rating: 3.9)",
"Cereals ready-to-eat, GENERAL MILLS, KABOOM (1.4  ND Rating: 3.8)",
"Spices, poultry seasoning (2.2  ND Rating: 5)",
"Spices, cumin seed (2.2  ND Rating: 4.9)",
"Babyfood, cereal, whole wheat, with apples, dry (2.1  ND Rating: 4.5)",
"Cereals, QUAKER, Instant Oatmeal, raisins, dates and walnuts, dry (1.8  ND Rating: 4.1)",
"Babyfood, cereal, mixed, dry (2  ND Rating: 4.3)",
"Cereals ready-to-eat, GENERAL MILLS, HONEY NUT CHEERIOS (1.9  ND Rating: 4.2)",
"Cereals ready-to-eat, QUAKER, Oatmeal Cereal, Brown Sugar Bliss (1.8  ND Rating: 4.1)",
"Cereals ready-to-eat, KASHI MIGHTY BITES, Honey Crunch Cereal (2.2  ND Rating: 4.8)",
"Cereals ready-to-eat, KASHI MIGHTY BITES, Cinnamon Cereal (2.2  ND Rating: 4.7)",
"Babyfood, cereal, barley, dry (2  ND Rating: 4.3)",
"Cereals ready-to-eat, Malt-O-Meal Honey Graham Cereal (1.6  ND Rating: 3.9)",
"Cereals, ready-to-eat, MALT-O-MEAL, TOASTY O'S (2.1  ND Rating: 4.5)",
"Cereals ready-to-eat, GENERAL MILLS, Corn CHEX (1.7  ND Rating: 4)",
"Cereals ready-to-eat, GENERAL MILLS, Rice CHEX (1.6  ND Rating: 3.9)",
"Seaweed, agar, dried (1.9  ND Rating: 4.1)",
"Spices, celery seed (2.2  ND Rating: 4.7)"
            };
        }
    }
}
