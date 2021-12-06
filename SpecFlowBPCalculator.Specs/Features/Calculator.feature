Feature: Calculator
![Calculator](https://upload.wikimedia.org/wikipedia/commons/4/41/2020_Sfigmomanometr_elektroniczny.jpg)
Simple blood pressure calculator

Link to a feature: [Calculator](SpecFlowBPCalculator.Specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: High blood pressure
	Given the systolic number is 170
	And the diastolic number is 95
	When the blood pressure is determined 
	Then the result should be High