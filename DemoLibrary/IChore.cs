﻿namespace DemoLibrary
{
    public interface IChore
    {
		string ChoreName { get; set; }
		IPerson Owner { get; set; }
		double HoursWorked { get; }
		bool IsComplete { get; set; }
		void PerformedWork(double hours);
		void CompleteChore();
	}
}