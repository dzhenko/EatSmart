namespace EatSmart.Logic
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoodForNutrientFetcher
    {
        public FoodForNutrientFetcher()
        {
            this.PopulateDictionary();
        }

        public IEnumerable<string> GetBestFood(string nutrient)
        {
            if (this.foodsInfoHolder.ContainsKey(nutrient))
            {
                return this.foodsInfoHolder[nutrient];
            }

            return new List<string>() { "Nutrient not found" };
        }

        private readonly Dictionary<string, IEnumerable<string>> foodsInfoHolder =
            new Dictionary<string, IEnumerable<string>>();


        private void PopulateDictionary()
        {
            if (this.foodsInfoHolder.Keys.Count > 0)
            {
                return;
            }

            foodsInfoHolder.Add("Total Carbohydrate", new List<string>() 
            {
                "Taco Bell condiment: Border Sauce, fire (2500g)",
"Taco Bell condiment: Picante Sauce (2222g)",
"Syrups, dietetic (246g)",
"Candies, gum drops, dietetic or low calorie (sorbitol) (109g)",
"Lemons, raw, with peel (107g)",
"Leavening agents, baking powder, double-acting, sodium aluminum sulfate (105g)",
"CAMPBELL Soup Company, PACE, Jalapenos Nacho Sliced Peppers (102g)",
"Leavening agents, baking powder, low-sodium (97g)",
"Leavening agents, baking powder, double-acting, straight phosphate (94g)",
"Del Taco taco: Coffee (88g)",
"Cereals ready-to-eat, GENERAL MILLS, FIBER ONE (83g)",
"Jams and preserves, dietetic (with sodium saccharin), any flavor (81g)",
"Gelatin desserts, dry mix, reduced calorie, with aspartame (81g)",
"Fruit-flavored drink mix, powder, unsweetened (81g)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN WITH EXTRA FIBER (80g)",
"Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (80g)",
"Carob flour (80g)",
"Fruit-flavored drink, dry powdered mix, low calorie, with aspartame (80g)",
"Wendy's condiment: Hot Chili Seasoning (80g)",
"Orange-flavor drink, breakfast type, low calorie, powder (79g)"
            });

            foodsInfoHolder.Add("Dietary Fiber", new List<string>() 
            {
                "Corn bran, crude (71g)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN WITH EXTRA FIBER (52g)",
"CAMPBELL Soup Company, PACE, Jalapenos Nacho Sliced Peppers (51g)",
"Fungi, Cloud ears, dried (49g)",
"Cereals ready-to-eat, GENERAL MILLS, FIBER ONE (47g)",
"Lemons, raw, with peel (47g)",
"Lemon peel, raw (45g)",
"Waxgourd, (chinese preserving melon), raw (45g)",
"Spices, cinnamon, ground [Cassia] (43g)",
"Cereals ready-to-eat, QUAKER, KRETSCHMER Toasted Wheat Bran (41g)",
"Wheat bran, crude (40g)",
"Pectin, liquid (38g)",
"Chicory, witloof, raw (36g)",
"Endive, raw (36g)",
"Cattail, Narrow Leaf Shoots (Northern Plains Indians) (36g)",
"Carob flour (36g)",
"Turnip greens, cooked, boiled, drained, with salt (35g)",
"Turnip greens, cooked, boiled, drained, without salt (35g)",
"Chicory greens, raw (35g)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN BRAN BUDS (34g)"
            });

            foodsInfoHolder.Add("Linoleic Acid", new List<string>() 
            {
                "Coffee, brewed, espresso, restaurant-prepared, decaffeinated (18399mg)",
"Oil, vegetable safflower, salad or cooking, linoleic, (over 70%) (2 undifferentiated: 16880mg)",
"Oil, vegetable, grapeseed (2 undifferentiated: 15744mg)",
"Oil, vegetable, sunflower, linoleic, (approx. 65%) (2 undifferentiated: 14864mg)",
"Salad dressing, mayonnaise, soybean and safflower oil, with salt (2 undifferentiated: 14506mg)",
"Oil, vegetable, poppyseed (2 undifferentiated: 14115mg)",
"USDA Commodity Food, oil, vegetable, low saturated fat (2 undifferentiated: 13059mg)",
"Oil, wheat germ (2 undifferentiated: 12397mg)",
"Oil, vegetable, corn, industrial and retail, all purpose salad or cooking (2 undifferentiated: 12106mg)",
"Seeds, sunflower seed kernels, toasted, with salt added (2 undifferentiated: 12079mg)",
"Seeds, sunflower seed kernels, toasted, without salt (2 undifferentiated: 12079mg)",
"Oil, vegetable, walnut (2 undifferentiated: 11967mg)",
"Mayonnaise dressing, no cholesterol (2 undifferentiated: 11791mg)",
"Oil, vegetable, cottonseed, salad or cooking (2 undifferentiated: 11652mg)",
"Nuts, walnuts, english [Includes USDA commodity food A259, A257] (2 undifferentiated: 11648mg)",
"Oil, vegetable, industrial, soy, refined, for woks and light frying (2 undifferentiated: 11603mg)",
"Seeds, sunflower seed kernels, oil roasted, with salt added (2 undifferentiated: 11555mg)",
"Seeds, sunflower seed kernels, oil roasted, without salt (2 undifferentiated: 11555mg)",
"Oil, soybean, salad or cooking (2 undifferentiated: 11529mg)",
"Oil, vegetable, tomatoseed (2 undifferentiated: 11492mg)"
            });

            foodsInfoHolder.Add("Alpha-Linolenic Acid", new List<string>() 
            {
                "Oil, vegetable, canola [low erucic acid rapeseed oil] (2067mg)",
"Margarine, 80% fat, tub, CANOLA HARVEST Soft Spread (canola, palm and palm kernel oils) (1692mg)",
"Oil, vegetable, industrial, soy, refined, for woks and light frying (1564mg)",
"Oil, soybean, salad or cooking (1536mg)",
"USDA Commodity Food, oil, vegetable, soybean, refined (1479mg)",
"Oil, industrial, canola with antifoaming agent, principal uses salads, woks and light frying (1447mg)",
"Oil, vegetable, industrial, canola for salads, woks and light frying (1434mg)",
"Oil, cooking and salad, ENOVA, 80% diglycerides (1411mg)",
"McDONALD'S, Creamy Ranch Sauce (1382mg)",
"Mustard, prepared, yellow (1367mg)",
"McDONALD'S, Spicy Buffalo Sauce (1355mg)",
"USDA Commodity Food, oil, vegetable, low saturated fat (1349mg)",
"Margarine, regular, tub, composite, 80% fat, with salt (1312mg)",
"Oil, corn and canola (1312mg)",
"Salad dressing, mayonnaise, soybean oil, with salt (1310mg)",
"Salad dressing, ranch dressing, commercial, regular (1265mg)",
"Salad dressing, mayonnaise, light [lite mayonnaise] (1184mg)",
"Margarine-like spread, BENECOL Light Spread (1107mg)",
"Margarine-like spread, (approximately 37% fat), unspecified oils (1035mg)",
"Margarine, vegetable oil spread, stick/tub/bottle, 60% fat (1006mg)"
            });

            foodsInfoHolder.Add("Protein", new List<string>() 
            {
                "Arby's beverage: Coffee (80g)",
"Carl's Jr. beverage: Coffee (59g)",
"Soy protein isolate, potassium type, crude protein basis (55g)",
"Gelatins, dry powder, unsweetened (51g)",
"Soy protein isolate, potassium type (50g)",
"Seal, bearded (Oogruk), meat, raw (Alaska Native) (49g)",
"Duck, scoter, white-winged, meat (Alaska Native) (48g)",
"Soy protein isolate (48g)",
"Whale, beluga, meat, raw (Alaska Native) (48g)",
"Seal, bearded (Oogruk), meat, dried (Alaska Native) [Oogruk] (47g)",
"Sea cucumber, yane (Alaska Native) (46g)",
"Seal, bearded (Oogruk), meat, partially dried (Alaska Native) (46g)",
"Seaweed, spirulina, raw (46g)",
"Walrus, meat, dried (Alaska Native) (45g)",
"Egg, white, raw, fresh (45g)",
"Fish, lingcod, meat, raw (Alaska Native) (45g)",
"Soy protein isolate, PROTEIN TECHNOLOGIES INTERNATIONAL, ProPlus (45g)",
"Soy protein isolate, PROTEIN TECHNOLOGIES INTERNATIONAL, SUPRO (45g)",
"Frog legs, raw (45g)",
"Emu, outside drum, raw (45g)"
            });

            foodsInfoHolder.Add("Vitamin A", new List<string>() 
            {
                "Taco Bell condiment: Border Sauce, mild (1000043IU)",
"Taco Bell condiment: Border Sauce, fire (749925IU)",
"Taco Bell condiment: Border Sauce, hot (749925IU)",
"Walrus, liver, raw (Alaska Native) (129925IU)",
"Moose, liver, braised (Alaska Native) (123893IU)",
"Broccoli, leaves, raw (114299IU)",
"Peppers, hot chili, red, canned, excluding seeds, solids and liquids (113240IU)",
"Babyfood, carrots, toddler (113166IU)",
"Carrots, canned, regular pack, solids and liquids (106638IU)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Fruit Medley (105061IU)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Strawberry Kiwi (105061IU)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Tropical Blend (105061IU)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Berry Blend (102890IU)",
"Mustard spinach, (tendergreen), cooked, boiled, drained, with salt (102508IU)",
"Mustard spinach, (tendergreen), cooked, boiled, drained, without salt (102508IU)",
"Lettuce, cos or romaine, raw (102475IU)",
"Lettuce, green leaf, raw (98727IU)",
"Kale, frozen, cooked, boiled, drained, with salt (98029IU)",
"Kale, frozen, cooked, boiled, drained, without salt (98029IU)",
"Carrots, cooked, boiled, drained, with salt (97338IU)"
            });

            foodsInfoHolder.Add("Vitamin C", new List<string>() 
            {
                "Acerola juice, raw (13913mg)",
"Acerola, (west indian cherry), raw (10483mg)",
"Apple cider-flavored drink, powder, low calorie, with vitamin C, prepared (4999mg)",
"Orange-flavor drink, breakfast type, low calorie, powder (2212mg)",
"Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (2114mg)",
"Sauce, ready-to-serve, pepper or hot (1360mg)",
"Peppers, sweet, yellow, raw (1359mg)",
"Peppers, sweet, red, cooked, boiled, drained, with salt (1316mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Fruit Medley (1260mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Strawberry Kiwi (1260mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Tropical Blend (1260mg)",
"Breakfast type drink, orange flavor, reduced sugar (1255mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Berry Blend (1235mg)",
"Peppers, sweet, red, cooked, boiled, drained, without salt (1222mg)",
"Peppers, hot chili, green, raw (1213mg)",
"Peppers, sweet, green, freeze-dried (1210mg)",
"Peppers, sweet, red, freeze-dried (1210mg)",
"Pokeberry shoots, (poke), raw (1183mg)",
"Mustard spinach, (tendergreen), raw (1182mg)",
"McDONALD'S, Apple Dippers (1154mg)"
            });

            foodsInfoHolder.Add("Vitamin D", new List<string>() 
            {
                "Fish oil, cod liver (2217IU)",
"Fish, herring, Atlantic, raw (2061IU)",
"Fish, catfish, channel, wild, raw (1053IU)",
"Mollusks, oyster, eastern, wild, raw (941IU)",
"Fish, salmon, sockeye, canned, drained solids with bone (920IU)",
"Fish, salmon, pink, canned, solids with bone and liquid (898IU)",
"Steelhead trout, boiled, canned (Alaska Native) (760IU)",
"Fish, salmon, pink, canned, drained solids with bone (685IU)",
"Fish, halibut, Greenland, raw (645IU)",
"Vitasoy USA, Nasoya Lite Firm Tofu (581IU)",
"Fish, herring, Atlantic, pickled (519IU)",
"Fish, sardine, Pacific, canned in tomato sauce, drained solids with bone (516IU)",
"Fish, mackerel, Atlantic, raw (351IU)",
"SILK Light Plain, soymilk (338IU)",
"Steelhead trout, dried, flesh (Shoshone Bannock) (329IU)",
"Fish, mackerel, jack, canned, drained solids (323IU)",
"Fish, salmon, chum, drained solids with bone (318IU)",
"Soymilk, original and vanilla, light, with added calcium, vitamins A and D (313IU)",
"Soymilk (all flavors), nonfat, with added calcium, vitamins A and D (304IU)",
"Infant formula, ABBOT NUTRITION, SIMILAC, SPECIAL CARE, ADVANCE 24, with iron, ready-to-feed, with ARA and DHA, (formerly ROSS) (303IU)"
            });

            foodsInfoHolder.Add("Vitamin E", new List<string>() 
            {
                "QUAKER OATS, PROPEL Fitness Water, fruit-flavored, non-carbonated [sport drink, thirst quencher] (67mg)",
"Formulated Bar, MASTERFOODS USA, SNICKERS MARATHON Protein Performance Bar, Caramel Nut Rush (62mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Fruit Medley (57mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Strawberry Kiwi (57mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Tropical Blend (57mg)",
"CAMPBELL Soup Company, V8 SPLASH Juice Drinks, Diet Berry Blend (56mg)",
"CAMPBELL Soup Company, V8 Vegetable Juice, Essential Antioxidants V8 (55mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (52mg)",
"Vitasoy USA, Nasoya Lite Firm Tofu (43mg)",
"Salad dressing, sweet and sour (34mg)",
"Oil, wheat germ (34mg)",
"Mollusks, clam, mixed species, canned, liquid (31mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN COMPLETE Wheat Flakes [Includes USDA Commodity B876] (29mg)",
"Breakfast type drink, orange flavor, reduced sugar (28mg)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (27mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S PRODUCT 19 (27mg)",
"Cereals, KASHI HEART TO HEART, Instant Oatmeal, Raisin Spice, dry (26mg)",
"Cereals, KASHI HEART TO HEART, Instant Oatmeal, Apple Cinnamon, dry (25mg)",
"Chrysanthemum, garland, cooked, boiled, drained, with salt (25mg)",
"Chrysanthemum, garland, cooked, boiled, drained, without salt (25mg)"
            });

            foodsInfoHolder.Add("Vitamin K", new List<string>() 
            {
                "Amaranth leaves, raw (9914mcg)",
"Parsley, raw (9113mcg)",
"Chard, swiss, raw (8738mcg)",
"Kale, frozen, cooked, boiled, drained, with salt (5880mcg)",
"Kale, frozen, cooked, boiled, drained, without salt (5880mcg)",
"Kale, cooked, boiled, drained, without salt (5837mcg)",
"Watercress, raw (4545mcg)",
"Spinach, cooked, boiled, drained, with salt (4292mcg)",
"Spinach, cooked, boiled, drained, without salt (4292mcg)",
"Spinach, raw (4199mcg)",
"Spinach, canned, drained solids (4013mcg)",
"Mustard greens, cooked, boiled, drained, with salt (3994mcg)",
"Mustard greens, cooked, boiled, drained, without salt (3994mcg)",
"Mustard greens, raw (3826mcg)",
"Turnip greens, cooked, boiled, drained, with salt (3675mcg)",
"Turnip greens, cooked, boiled, drained, without salt (3675mcg)",
"Beet greens, raw (3637mcg)",
"Basil, fresh (3606mcg)",
"Beet greens, cooked, boiled, drained, with salt (3585mcg)",
"Beet greens, cooked, boiled, drained, without salt (3585mcg)"
            });

            foodsInfoHolder.Add("Thiamin", new List<string>() 
            {
                "WORTHINGTON Prosage Links, frozen, unprepared (23mg)",
"WORTHINGTON Meatless Corned Beef, frozen, unprepared (17mg)",
"MORNINGSTAR FARMS Spicy Black Bean Burger, frozen, unprepared (16mg)",
"MORNINGSTAR FARMS Garden Veggie Patties, frozen, unprepared (13mg)",
"Yeast extract spread (12mg)",
"MORNINGSTAR FARMS Veggie Sausage Patties, frozen, unprepared (10mg)",
"WORTHINGTON FriPats, frozen, unprepared (10mg)",
"MORNINGSTAR FARMS Veggie Bacon Strips, frozen, unprepared (6mg)",
"WORTHINGTON Stripples, frozen, unprepared (6mg)",
"Margarine spread, fat-free, tub (5mg)",
"Formulated bar, POWER BAR, chocolate (4mg)",
"Luncheon slices, meatless (4mg)",
"Cereals ready-to-eat, Ralston Crispy Hexagons [Includes USDA Commodity Corn and Rice B855] (4mg)",
"Tea, ready-to-drink, unsweetened, WENDY'S, fast food, without ice (4mg)",
"Leavening agents, yeast, baker's, compressed (4mg)",
"Cereals ready-to-eat, USDA Commodity Corn and Rice (includes all commodity brands) [Includes USDA Commodity B855] (3mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN COMPLETE Wheat Flakes [Includes USDA Commodity B876] (3mg)",
"WORTHINGTON Turkee Slices, canned, unprepared (3mg)",
"Babyfood, apple yogurt dessert, strained (3mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S Complete Oat Bran Flakes (3mg)"
            });

            foodsInfoHolder.Add("Riboflavin", new List<string>() 
            {
                "Coffee, brewed, espresso, restaurant-prepared, decaffeinated (35mg)",
"Energy drink, RED BULL, sugar free, with added caffeine, niacin, pantothenic acid, vitamins B6 and B12 (23mg)",
"Yeast extract spread (18mg)",
"Coffee, brewed, espresso, restaurant-prepared (18mg)",
"Coffee, brewed from grounds, prepared with tap water (15mg)",
"Orange-flavor drink, breakfast type, low calorie, powder (6mg)",
"Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (6mg)",
"Beef, variety meats and by-products, kidneys, raw (6mg)",
"Moose, liver, braised (Alaska Native) (5mg)",
"Lamb, variety meats and by-products, liver, raw (5mg)",
"Tea, ready-to-drink, unsweetened, WENDY'S, fast food, without ice (5mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (5mg)",
"Orange drink, breakfast type, with juice and pulp, frozen concentrate (5mg)",
"Orange drink, breakfast type, with juice and pulp, frozen concentrate, prepared with water (5mg)",
"Lamb, variety meats and by-products, kidneys, raw (5mg)",
"Carbonated beverage, low calorie, cola or pepper-type, with aspartame, without caffeine [pop, soda, soft drink] (5mg)",
"Pork, fresh, variety meats and by-products, liver, raw (4mg)",
"Beef, variety meats and by-products, liver, raw (4mg)",
"Beef, variety meats and by-products, liver, cooked, pan-fried (4mg)",
"Fireweed, young leaves, raw (Alaska Native) (4mg)"
            });

            foodsInfoHolder.Add("Niacin", new List<string>() 
            {
                "Coffee, brewed, espresso, restaurant-prepared, decaffeinated (1041mg)",
"Coffee, brewed, espresso, restaurant-prepared (521mg)",
"Energy drink, RED BULL, sugar free, with added caffeine, niacin, pantothenic acid, vitamins B6 and B12 (340mg)",
"QUAKER OATS, PROPEL Fitness Water, fruit-flavored, non-carbonated [sport drink, thirst quencher] (164mg)",
"Yeast extract spread (123mg)",
"Orange-flavor drink, breakfast type, low calorie, powder (74mg)",
"Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (70mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (58mg)",
"Coffee, brewed from grounds, prepared with tap water, decaffeinated (44mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN COMPLETE Wheat Flakes [Includes USDA Commodity B876] (43mg)",
"Breakfast type drink, orange flavor, reduced sugar (42mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S PRODUCT 19 (40mg)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (40mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S Complete Oat Bran Flakes (40mg)",
"Coffee, brewed from grounds, prepared with tap water (38mg)",
"Energy drink, RED BULL, with added caffeine, niacin, pantothenic acid, vitamins B6 and B12 (38mg)",
"Cereals ready-to-eat, GENERAL MILLS, Multi-Grain Cheerios (36mg)",
"Cereals ready-to-eat, GENERAL MILLS, TOTAL Corn Flakes (36mg)",
"Mushrooms, Maitake, Raw (36mg)",
"Mushrooms, portabella, raw [Portabello] (35mg)"
            });

            foodsInfoHolder.Add("Vitamin B6", new List<string>() 
            {
                "Energy drink, RED BULL, sugar free, with added caffeine, niacin, pantothenic acid, vitamins B6 and B12 (33mg)",
"QUAKER OATS, PROPEL Fitness Water, fruit-flavored, non-carbonated [sport drink, thirst quencher] (22mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN Original (9mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN WITH EXTRA FIBER (8mg)",
"Orange-flavor drink, breakfast type, low calorie, powder (7mg)",
"Fruit-flavored drink, powder, with high vitamin C with other added vitamins, low calorie (7mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN BRAN BUDS (5mg)",
"Balsam-pear (bitter gourd), leafy tips, raw (5mg)",
"Cereals ready-to-eat, MALT-O-MEAL, High Fiber Bran Flakes (5mg)",
"Balsam-pear (bitter gourd), leafy tips, cooked, boiled, drained, with salt (5mg)",
"Balsam-pear (bitter gourd), leafy tips, cooked, boiled, drained, without salt (4mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN COMPLETE Wheat Flakes [Includes USDA Commodity B876] (4mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (4mg)",
"New Zealand spinach, raw (4mg)",
"Breakfast type drink, orange flavor, reduced sugar (4mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S PRODUCT 19 (4mg)",
"Cereals ready-to-eat, Ralston Crispy Hexagons [Includes USDA Commodity Corn and Rice B855] (4mg)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (4mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S Complete Oat Bran Flakes (4mg)",
"New zealand spinach, cooked, boiled, drained, with salt (4mg)"
            });

            foodsInfoHolder.Add("Folate", new List<string>() 
            {
                "Spinach, raw (1687mcg)",
"Endive, raw (1670mcg)",
"Lettuce, cos or romaine, raw (1600mcg)",
"Asparagus, frozen, unprepared (1592mcg)",
"Leavening agents, yeast, baker's, active dry (1587mcg)",
"Asparagus, frozen, cooked, boiled, drained, with salt (1500mcg)",
"Asparagus, frozen, cooked, boiled, drained, without salt (1500mcg)",
"Leavening agents, yeast, baker's, compressed (1495mcg)",
"Chrysanthemum leaves, raw (1475mcg)",
"Chrysanthemum, garland, raw (1475mcg)",
"Vinespinach, (basella), raw (1474mcg)",
"Mustard spinach, (tendergreen), raw (1445mcg)",
"Mustard greens, raw (1439mcg)",
"Mustard greens, frozen, unprepared (1380mcg)",
"Asparagus, cooked, boiled, drained (1355mcg)",
"Asparagus, cooked, boiled, drained, with salt (1355mcg)",
"Epazote, raw (1344mcg)",
"Yeast extract spread (1279mcg)",
"Spinach, cooked, boiled, drained, with salt (1270mcg)",
"Spinach, cooked, boiled, drained, without salt (1270mcg)"
            });

            foodsInfoHolder.Add("Vitamin B12", new List<string>() 
            {
                "Mollusks, clam, mixed species, canned, liquid (500mcg)",
"Mollusks, clam, mixed species, canned, drained solids (134mcg)",
"Mollusks, clam, mixed species, cooked, moist heat (134mcg)",
"Mollusks, clam, mixed species, raw (134mcg)",
"Lamb, variety meats and by-products, liver, raw (130mcg)",
"Lamb, variety meats and by-products, kidneys, cooked, braised (115mcg)",
"Fish, whitefish, eggs (Alaska Native) (108mcg)",
"Lamb, variety meats and by-products, kidneys, raw (108mcg)",
"Beef, variety meats and by-products, liver, cooked, pan-fried (95mcg)",
"Moose, liver, braised (Alaska Native) (92mcg)",
"Veal, variety meats and by-products, liver, cooked, braised [calf liver] (88mcg)",
"Beef, variety meats and by-products, liver, raw (88mcg)",
"Veal, variety meats and by-products, liver, raw [calf liver] (86mcg)",
"Goose, liver, raw (81mcg)",
"Duck, domesticated, liver, raw (79mcg)",
"Mollusks, oyster, eastern, wild, cooked, dry heat (77mcg)",
"Veal, variety meats and by-products, liver, cooked, pan-fried [calf liver] (75mcg)",
"Beef, variety meats and by-products, liver, cooked, braised (74mcg)",
"Lamb, variety meats and by-products, liver, cooked, pan-fried (72mcg)",
"Energy drink, RED BULL, sugar free, with added caffeine, niacin, pantothenic acid, vitamins B6 and B12 (70mcg)"
            });

            foodsInfoHolder.Add("Pantothenic Acid", new List<string>() 
            {
                "QUAKER OATS, PROPEL Fitness Water, fruit-flavored, non-carbonated [sport drink, thirst quencher] (63mg)",
"Energy drink, RED BULL, sugar free, with added caffeine, niacin, pantothenic acid, vitamins B6 and B12 (56mg)",
"Coffee, brewed from grounds, prepared with tap water (51mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN COMPLETE Wheat Flakes [Includes USDA Commodity B876] (22mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S PRODUCT 19 (20mg)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (20mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S Complete Oat Bran Flakes (20mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (19mg)",
"Cereals ready-to-eat, GENERAL MILLS, Multi-Grain Cheerios (18mg)",
"Cereals ready-to-eat, GENERAL MILLS, TOTAL Corn Flakes (18mg)",
"Jew's ear, (pepeao), raw (16mg)",
"Mushrooms, cooked, boiled, drained, with salt (15mg)",
"Mushrooms, cooked, boiled, drained, without salt (15mg)",
"Mushrooms, shiitake, dried (15mg)",
"Pepeao, dried (14mg)",
"Mushrooms, white, raw (14mg)",
"Mushrooms, shiitake, cooked, with salt (13mg)",
"Formulated Bar, MASTERFOODS USA, SNICKERS Marathon Double Chocolate Nut Bar (13mg)",
"Mushrooms, shiitake, cooked, without salt (13mg)",
"Grape leaves, canned (12mg)"
            });

            foodsInfoHolder.Add("Calcium", new List<string>() 
            {
                "Leavening agents, baking powder, double-acting, straight phosphate (28874mg)",
"Leavening agents, baking powder, double-acting, sodium aluminum sulfate (22174mg)",
"Leavening agents, baking powder, low-sodium (8931mg)",
"Desserts, rennin, tablets, unsweetened (8888mg)",
"Salt, table (4800mg)",
"Water, bottled, PERRIER (2800mg)",
"Butterbur, canned (2266mg)",
"Apple cider-flavored drink, powder, low calorie, with vitamin C, prepared (2200mg)",
"Nopales, cooked, without salt (2187mg)",
"Watercress, raw (2181mg)",
"Tofu, salted and fermented (fuyu), prepared with calcium sulfate (2119mg)",
"Nopales, raw (2050mg)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (2001mg)",
"Water, bottled, generic (2000mg)",
"Amaranth leaves, cooked, boiled, drained, with salt (1991mg)",
"Amaranth leaves, cooked, boiled, drained, without salt (1991mg)",
"Mustard spinach, (tendergreen), cooked, boiled, drained, with salt (1975mg)",
"Mustard spinach, (tendergreen), cooked, boiled, drained, without salt (1975mg)",
"Mustard spinach, (tendergreen), raw (1909mg)",
"Amaranth leaves, raw (1870mg)"
            });

            foodsInfoHolder.Add("Copper", new List<string>() 
            {
                "Mollusks, clam, mixed species, canned, liquid (39mg)",
"Veal, variety meats and by-products, liver, raw [calf liver] (17mg)",
"Beef, variety meats and by-products, liver, cooked, pan-fried (17mg)",
"Veal, variety meats and by-products, liver, cooked, pan-fried [calf liver] (16mg)",
"Veal, variety meats and by-products, liver, cooked, braised [calf liver] (16mg)",
"Beef, variety meats and by-products, liver, cooked, braised (15mg)",
"Beef, variety meats and by-products, liver, raw (14mg)",
"Mollusks, oyster, eastern, wild, raw (13mg)",
"Mollusks, oyster, eastern, canned (13mg)",
"Goose, liver, raw (11mg)",
"Mollusks, oyster, eastern, wild, cooked, moist heat (11mg)",
"Lamb, variety meats and by-products, liver, raw (10mg)",
"Coffee, brewed, espresso, restaurant-prepared, decaffeinated (10mg)",
"Mollusks, oyster, eastern, wild, cooked, dry heat (10mg)",
"Duck, domesticated, liver, raw (9mg)",
"Lamb, variety meats and by-products, liver, cooked, pan-fried (8mg)",
"Lamb, variety meats and by-products, liver, cooked, braised (6mg)",
"Salt, table (6mg)",
"Soup, oyster stew, canned, prepared with equal volume water (6mg)",
"Soup, oyster stew, canned, condensed (5mg)"
            });

            foodsInfoHolder.Add("Iron", new List<string>() 
            {
                "Spices, thyme, dried (90mg)",
"Beef, variety meats and by-products, spleen, raw (85mg)",
"Lamb, variety meats and by-products, spleen, raw (83mg)",
"Spices, parsley, dried (71mg)",
"Salt, table (66mg)",
"Oopah (tunicate), whole animal (Alaska Native) (62mg)",
"Spearmint, dried [mint] (61mg)",
"Spices, marjoram, dried (61mg)",
"Beef, variety meats and by-products, spleen, cooked, braised (54mg)",
"Spearmint, fresh [mint] (54mg)",
"Lamb, variety meats and by-products, spleen, cooked, braised (50mg)",
"Jamba Juice beverage: Juice, Wheatgrass (48mg)",
"Whale, beluga, meat, raw (Alaska Native) (47mg)",
"Goose, liver, raw (46mg)",
"Duck, domesticated, liver, raw (45mg)",
"Pork, fresh, variety meats and by-products, spleen, raw (45mg)",
"Pork, fresh, variety meats and by-products, lungs, raw (44mg)",
"Whale, beluga, meat, dried (Alaska Native) (44mg)",
"Leavening agents, baking powder, double-acting, straight phosphate (44mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (44mg)"
            });

            foodsInfoHolder.Add("Magnesium", new List<string>() 
            {
                "Coffee, brewed, espresso, restaurant-prepared, decaffeinated (15999mg)",
"Coffee, brewed, espresso, restaurant-prepared (8000mg)",
"Mollusks, clam, mixed species, canned, liquid (1100mg)",
"Coffee, brewed from grounds, prepared with tap water, decaffeinated (1000mg)",
"Sauce, fish, ready-to-serve (1000mg)",
"Dock, raw (937mg)",
"Dock, cooked, boiled, drained, with salt (890mg)",
"Dock, cooked, boiled, drained, without salt (890mg)",
"Chard, swiss, cooked, boiled, drained, with salt (860mg)",
"Chard, swiss, cooked, boiled, drained, without salt (860mg)",
"Chard, swiss, raw (853mg)",
"Purslane, raw (850mg)",
"Spinach, cooked, boiled, drained, with salt (756mg)",
"Spinach, cooked, boiled, drained, without salt (756mg)",
"Epazote, raw (756mg)",
"Swamp cabbage, (skunk cabbage), raw (747mg)",
"Purslane, cooked, boiled, drained, with salt (744mg)",
"Purslane, cooked, boiled, drained, without salt (744mg)",
"Lambsquarters, raw (Northern Plains Indians) (694mg)",
"Spinach, raw (687mg)"
            });

            foodsInfoHolder.Add("Manganese", new List<string>() 
            {
                "Tea, instant, unsweetened, powder (84mg)",
"Tea, instant, unsweetened, powder, decaffeinated (84mg)",
"Tea, instant, unsweetened, powder, prepared (78mg)",
"Tea, brewed, prepared with distilled water [black tea] (44mg)",
"Tea, brewed, prepared with tap water [black tea] (44mg)",
"Tea, brewed, prepared with tap water, decaffeinated [black tea] (44mg)",
"Tea, ready-to-drink, unsweetened, WENDY'S, fast food, without ice (27mg)",
"Salt, table (20mg)",
"Infant formula, ABBOTT NUTRITION, NEOSURE ADVANCE, powder, with ARA and DHA, (formerly ROSS) (20mg)",
"Epazote, raw (19mg)",
"Spices, cloves, ground (19mg)",
"Spices, saffron (18mg)",
"Spices, cardamom (18mg)",
"Tea, instant, sweetened with sodium saccharin, lemon-flavored, powder (18mg)",
"Tea, instant, sweetened with sodium saccharin, lemon-flavored, powder, decaffeinated (18mg)",
"Tea, instant, unsweetened, lemon-flavored, powder (18mg)",
"Cereals ready-to-eat, QUAKER, KRETSCHMER Toasted Wheat Bran (17mg)",
"Tea, instant, sweetened with sodium saccharin, lemon-flavored, prepared (15mg)",
"Spices, ginger, ground (15mg)",
"Spices, cinnamon, ground [Cassia] (14mg)"
            });

            foodsInfoHolder.Add("Phosphorus", new List<string>() 
            {
                "Leavening agents, baking powder, double-acting, straight phosphate (38890mg)",
"Leavening agents, baking powder, low-sodium (14160mg)",
"Mollusks, clam, mixed species, canned, liquid (11402mg)",
"Leavening agents, baking powder, double-acting, sodium aluminum sulfate (8268mg)",
"Apple cider-flavored drink, powder, low calorie, with vitamin C, prepared (2400mg)",
"Carbonated beverage, low calorie, cola or pepper-types, with sodium saccharin, contains caffeine [pop, soda, soft drink] (2200mg)",
"Carbonated beverage, low calorie, cola or pepper-type, with aspartame, without caffeine [pop, soda, soft drink] (2000mg)",
"Coffee, brewed, espresso, restaurant-prepared, decaffeinated (1400mg)",
"Puddings, all flavors except chocolate, low calorie, instant, dry mix (1353mg)",
"Cereals ready-to-eat, QUAKER, KRETSCHMER Toasted Wheat Bran (1314mg)",
"Gelatin desserts, dry mix, reduced calorie, with aspartame (1306mg)",
"Cheese, pasteurized process, cheddar or american, fat-free (1265mg)",
"KRAFT FREE Singles American Nonfat Pasteurized Process Cheese Product (1247mg)",
"Fruit-flavored drink, dry powdered mix, low calorie, with aspartame (1142mg)",
"Pumpkin leaves, raw (1095mg)",
"Watercress, raw (1091mg)",
"Rice bran, crude (1062mg)",
"Veal, variety meats and by-products, thymus, raw (1055mg)",
"Veal, variety meats and by-products, thymus, cooked, braised (1003mg)",
"Mushrooms, portabella, raw [Portabello] (1000mg)"
            });

            foodsInfoHolder.Add("Selenium", new List<string>() 
            {
                "Sea lion, stellar, liver (Alaska Native) (1012mcg)",
"Sea lion, stellar, kidney (Alaska Native) (589mcg)",
"Nuts, brazilnuts, dried, unblanched (585mcg)",
"Pork, fresh, variety meats and by-products, kidneys, cooked, braised (413mcg)",
"Mollusks, clam, mixed species, canned, liquid (410mcg)",
"Pork, fresh, variety meats and by-products, kidneys, raw (380mcg)",
"Lamb, variety meats and by-products, kidneys, cooked, braised (319mcg)",
"Beef, variety meats and by-products, kidneys, raw (274mcg)",
"Lamb, variety meats and by-products, kidneys, raw (262mcg)",
"Sea lion, stellar, heart (Alaska Native) (239mcg)",
"Jellyfish, dried, salted (234mcg)",
"Turkey, all classes, giblets, raw (220mcg)",
"Mollusks, oyster, eastern, farmed, raw (216mcg)",
"Beef, variety meats and by-products, kidneys, cooked, simmered (213mcg)",
"Mollusks, oyster, eastern, wild, cooked, dry heat (199mcg)",
"Mollusks, oyster, eastern, farmed, cooked, dry heat (196mcg)",
"Mushrooms, brown, Italian, or Crimini, raw (193mcg)",
"Mollusks, oyster, Pacific, raw (190mcg)",
"Mollusks, oyster, Pacific, cooked, moist heat (189mcg)",
"Mollusks, oyster, eastern, wild, raw (187mcg)"
            });

            foodsInfoHolder.Add("Zinc", new List<string>() 
            {
                "Mollusks, oyster, eastern, wild, raw (267mg)",
"Mollusks, oyster, eastern, wild, cooked, moist heat (265mg)",
"Mollusks, oyster, eastern, canned (264mg)",
"Mollusks, oyster, eastern, wild, cooked, dry heat (204mg)",
"Mollusks, oyster, eastern, farmed, raw (129mg)",
"Mollusks, oyster, eastern, farmed, cooked, dry heat (114mg)",
"Mollusks, oyster, eastern, cooked, breaded and fried (88mg)",
"Cereals ready-to-eat, Ralston Enriched Bran flakes [Includes USDA Commodity B877] (42mg)",
"Mollusks, oyster, Pacific, raw (41mg)",
"Mollusks, oyster, Pacific, cooked, moist heat (41mg)",
"Soup, oyster stew, canned, prepared with equal volume water (36mg)",
"Soup, oyster stew, canned, condensed (35mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S ALL-BRAN COMPLETE Wheat Flakes [Includes USDA Commodity B876] (33mg)",
"Soy protein isolate, PROTEIN TECHNOLOGIES INTERNATIONAL, ProPlus (32mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S PRODUCT 19 (31mg)",
"Cereals ready-to-eat, GENERAL MILLS, Whole Grain TOTAL (30mg)",
"Cereals ready-to-eat, KELLOGG, KELLOGG'S Complete Oat Bran Flakes (30mg)",
"Cereals ready-to-eat, GENERAL MILLS, Multi-Grain Cheerios (27mg)",
"Cereals ready-to-eat, GENERAL MILLS, TOTAL Corn Flakes (27mg)",
"Babyfood, cereal, oatmeal, with applesauce and bananas, junior (20mg)"
            });
        }
    }
}
