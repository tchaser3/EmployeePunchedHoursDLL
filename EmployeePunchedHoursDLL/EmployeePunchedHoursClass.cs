/* Title:           Employee Punched Hours Class
 * Date:            10-12-18
 * Author:          Terrance Holmes
 * 
 * Description:     This is the class that does all employee hours */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace EmployeePunchedHoursDLL
{
    public class EmployeePunchedHoursClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        EmployeePunchedHoursDataSet aEmployeePunchedHoursDataSet;
        EmployeePunchedHoursDataSetTableAdapters.employeepunchedhoursTableAdapter aEmployeePunchedHoursTableAdapter;

        InsertEmployeePunchedHoursEntryTableAdapters.QueriesTableAdapter aInsertEmployeePunchedHoursTableAdapter;

        FindEmployeePunchedHoursDataSet aFindEmployeePunchedHoursDataSet;
        FindEmployeePunchedHoursDataSetTableAdapters.FindEmployeePunchedHoursTableAdapter aFindEmployeePunchedHoursTableAdapter;

        FindAllEmployeePunchedHoursDataSet aFindAllEmployeePunchedHoursDataSet;
        FindAllEmployeePunchedHoursDataSetTableAdapters.FindAllEmployeePunchedHoursTableAdapter aFindAllEmployeePunchedHoursTableAdapter;

        FindEmployeePunchesByManagerIDDataSet aFindEmployeePunchesByManagerIDDataSet;
        FindEmployeePunchesByManagerIDDataSetTableAdapters.FindEmployeePunchesByManagerIDTableAdapter aFindEmployeePunchesByManagerIDTableAdapter;

        FindEmployeesOverFortyHoursDataSet aFindEmployeesOverFortyHoursDataSet;
        FindEmployeesOverFortyHoursDataSetTableAdapters.FindEmployeesOverFortyHoursTableAdapter aFindEmployeesOverFortyHoursTableAdapter;

        FindDuplicateEmployeePunchedHoursDataSet aFindDuplicateEmployeePunchedHoursDataSet;
        FindDuplicateEmployeePunchedHoursDataSetTableAdapters.FindDuplicateEmployeePunchedHoursTableAdapter aFindDuplicateEmployeePunchedHoursTableAdpater;

        RemoveEmplolyeePunchedHoursEntryTableAdapters.QueriesTableAdapter aRemoveEmployeePunchedHoursTableAdapter;

        AlohaEmployeePunchesDataSet aAlohaEmployeePunchesDataSet;
        AlohaEmployeePunchesDataSetTableAdapters.alohaemployeepunchesTableAdapter aAlohaEmployeePunchesTableAdapter;

        InsertIntoAholaEmployeePunchEntryTableAdapters.QueriesTableAdapter aInsertIntoAholaEmployeePunchTableAdapter;

        FindAholaEmployeePunchForVerificationDataSet aFindAholaEmployeePunchForVerificationDataSet;
        FindAholaEmployeePunchForVerificationDataSetTableAdapters.FindAholaEmployeePunchForVerificationTableAdapter aFindAholaEmployeePunchForVerificationTableAdapter;

        FindAlohaEmployeePunchesByManagerDataSet aFindAlohaEmployeePunchesByManagerDataSet;
        FindAlohaEmployeePunchesByManagerDataSetTableAdapters.FindAlohaEmployeesPunchesByManagerTableAdapter aFindAlohaEmployeePunchesByManagerTableAdapter;

        FindAholaEmployeeTotalHoursDataSet aFindAholaEmployeeTotalHoursDataSet;
        FindAholaEmployeeTotalHoursDataSetTableAdapters.FindAholaEmployeeTotalHoursTableAdapter aFindAholaEmployeeTotalHoursTableAdapter;

        FindEmployeePunchedHoursForValidationDataSet aFindEmployeePunchedHoursForValidationDataSet;
        FindEmployeePunchedHoursForValidationDataSetTableAdapters.FindEmployeePunchedHoursForValidationTableAdapter aFindEmployeePunchedHoursForValidationTableAdapter;

        FindAlohaEmployeeHoursOverDateRangeDataSet aFindAlohaEmployeeHoursOverDateRangeDataSet;
        FindAlohaEmployeeHoursOverDateRangeDataSetTableAdapters.FindAlohaEmployeeHoursOverDateRangeTableAdapter aFindAlohaEmployeeHoursOverDateRangeTableAdapter;

        AholaClockPunchesDataSet aAholaClockPunchesDataSet;
        AholaClockPunchesDataSetTableAdapters.aholaclockpunchesTableAdapter aAholaClockPunchesTableAdapter;

        InsertAholaClockPunchesEntryTableAdapters.QueriesTableAdapter aInsertAholaClockPunchesTableAdapter;

        FindAholaClockPUnchesForEmployeeDataSet aFindAholaClockPunchesforEmployeeDataSet;
        FindAholaClockPUnchesForEmployeeDataSetTableAdapters.FindAholaClockPunchesForEmployeeTableAdapter aFindAholaClockPunchesForEmployeeTableAdapter;

        FindAholaClockPunchesForVerificationDataSet aFindAholaClockPunchesForVerificationDataSet;
        FindAholaClockPunchesForVerificationDataSetTableAdapters.FindAholaClockPunchesForVerificationTableAdapter aFindAholaClockPunchesForVerificationTableAdapter;

        UpdateAlohaTimePunchesEntryTableAdapters.QueriesTableAdapter aUpdateAlohatimePunchesTableAdapter;

        public bool UpdateAlohaTimePunches(int intTransactionID, DateTime datStartDate, DateTime datEndDate, decimal decDailyHours)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateAlohatimePunchesTableAdapter = new UpdateAlohaTimePunchesEntryTableAdapters.QueriesTableAdapter();
                aUpdateAlohatimePunchesTableAdapter.UpdateAlohaTimePunches(intTransactionID, datStartDate, datEndDate, decDailyHours);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Update Aloha Time Punches " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindAholaClockPunchesForVerificationDataSet FindAholaClockPunchesForVerification(int intPayID, DateTime datActualDateTime, DateTime datPunchDateTime, DateTime datCreatedDateTime, string strPunchIPAddress)
        {
            try
            {
                aFindAholaClockPunchesForVerificationDataSet = new FindAholaClockPunchesForVerificationDataSet();
                aFindAholaClockPunchesForVerificationTableAdapter = new FindAholaClockPunchesForVerificationDataSetTableAdapters.FindAholaClockPunchesForVerificationTableAdapter();
                aFindAholaClockPunchesForVerificationTableAdapter.Fill(aFindAholaClockPunchesForVerificationDataSet.FindAholaClockPunchesForVerification, intPayID, datActualDateTime, datPunchDateTime, datCreatedDateTime, strPunchIPAddress);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Ahola Clock Punches For Verification " + Ex.Message);
            }

            return aFindAholaClockPunchesForVerificationDataSet;
        }
        public FindAholaClockPUnchesForEmployeeDataSet FindAholaClockPunchesForEmployee(int intEmployeeID, DateTime dataStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAholaClockPunchesforEmployeeDataSet = new FindAholaClockPUnchesForEmployeeDataSet();
                aFindAholaClockPunchesForEmployeeTableAdapter = new FindAholaClockPUnchesForEmployeeDataSetTableAdapters.FindAholaClockPunchesForEmployeeTableAdapter();
                aFindAholaClockPunchesForEmployeeTableAdapter.Fill(aFindAholaClockPunchesforEmployeeDataSet.FindAholaClockPunchesForEmployee, intEmployeeID, dataStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Ahola Clock Punches For Employee " + Ex.Message);
            }

            return aFindAholaClockPunchesforEmployeeDataSet;
        }
        public bool InsertAholaClockPunches(int intEmployeeID, int intPayID, DateTime datActualDateTime, DateTime datPunchDateTime, DateTime datCreatedDateTime, string strPayGroup, string strPunchMode, string strPunchType, string strPunchSource, string strPunchUser, string strPunchIPAddress, DateTime datLastUpdate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertAholaClockPunchesTableAdapter = new InsertAholaClockPunchesEntryTableAdapters.QueriesTableAdapter();
                aInsertAholaClockPunchesTableAdapter.InsertAholaClockPunches(intEmployeeID, intPayID, datActualDateTime, datPunchDateTime, datCreatedDateTime, strPayGroup, strPunchMode, strPunchType, strPunchSource, strPunchUser, strPunchIPAddress, datLastUpdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Insert Ahola Clock Punches " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public AholaClockPunchesDataSet GetAholaClockPunchesInfo()
        {
            try
            {
                aAholaClockPunchesDataSet = new AholaClockPunchesDataSet();
                aAholaClockPunchesTableAdapter = new AholaClockPunchesDataSetTableAdapters.aholaclockpunchesTableAdapter();
                aAholaClockPunchesTableAdapter.Fill(aAholaClockPunchesDataSet.aholaclockpunches);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Get Ahola Clock Punches Info " + Ex.Message);
            }

            return aAholaClockPunchesDataSet;
        }
        public void UpdateAholaClockPunchesDB(AholaClockPunchesDataSet aAholaClockPunchesDataSet)
        {
            try
            {
                aAholaClockPunchesTableAdapter = new AholaClockPunchesDataSetTableAdapters.aholaclockpunchesTableAdapter();
                aAholaClockPunchesTableAdapter.Update(aAholaClockPunchesDataSet.aholaclockpunches);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Update Ahola Clock Punches DB " + Ex.Message);
            }
        }
        public FindAlohaEmployeeHoursOverDateRangeDataSet FindAlohaEmployeeHoursOverDateRange(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAlohaEmployeeHoursOverDateRangeDataSet = new FindAlohaEmployeeHoursOverDateRangeDataSet();
                aFindAlohaEmployeeHoursOverDateRangeTableAdapter = new FindAlohaEmployeeHoursOverDateRangeDataSetTableAdapters.FindAlohaEmployeeHoursOverDateRangeTableAdapter();
                aFindAlohaEmployeeHoursOverDateRangeTableAdapter.Fill(aFindAlohaEmployeeHoursOverDateRangeDataSet.FindAlohaEmployeeHoursOverDateRange, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Aloha Employee Hours Over Date Range " + Ex.Message);
            }

            return aFindAlohaEmployeeHoursOverDateRangeDataSet;
        }
        public FindEmployeePunchedHoursForValidationDataSet FindEmployeePunchedHoursForValidation(DateTime datTransactionDate, int intEmployeeID, int intPayID)
        {
            try
            {
                aFindEmployeePunchedHoursForValidationDataSet = new FindEmployeePunchedHoursForValidationDataSet();
                aFindEmployeePunchedHoursForValidationTableAdapter = new FindEmployeePunchedHoursForValidationDataSetTableAdapters.FindEmployeePunchedHoursForValidationTableAdapter();
                aFindEmployeePunchedHoursForValidationTableAdapter.Fill(aFindEmployeePunchedHoursForValidationDataSet.FindEmployeePunchedHoursForValidation, datTransactionDate, intEmployeeID, intPayID);  
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Employee Punched Hours For Validation " + Ex.Message);
            }

            return aFindEmployeePunchedHoursForValidationDataSet;
        }
        public FindAholaEmployeeTotalHoursDataSet FindAholaEmployeeTotalHours(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAholaEmployeeTotalHoursDataSet = new FindAholaEmployeeTotalHoursDataSet();
                aFindAholaEmployeeTotalHoursTableAdapter = new FindAholaEmployeeTotalHoursDataSetTableAdapters.FindAholaEmployeeTotalHoursTableAdapter();
                aFindAholaEmployeeTotalHoursTableAdapter.Fill(aFindAholaEmployeeTotalHoursDataSet.FindAholaEmployeeTotalHours, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Ahola Employee Total Hours " + Ex.Message);
            }

            return aFindAholaEmployeeTotalHoursDataSet;
        }
        public FindAlohaEmployeePunchesByManagerDataSet FindAlohaPunchesByManager(int intManagerID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAlohaEmployeePunchesByManagerDataSet = new FindAlohaEmployeePunchesByManagerDataSet();
                aFindAlohaEmployeePunchesByManagerTableAdapter = new FindAlohaEmployeePunchesByManagerDataSetTableAdapters.FindAlohaEmployeesPunchesByManagerTableAdapter();
                aFindAlohaEmployeePunchesByManagerTableAdapter.Fill(aFindAlohaEmployeePunchesByManagerDataSet.FindAlohaEmployeesPunchesByManager, intManagerID, datStartDate, datEndDate);  
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Aloha Punches By Manager " + Ex.Message);
            }

            return aFindAlohaEmployeePunchesByManagerDataSet;
        }
        public FindAholaEmployeePunchForVerificationDataSet FindAholaEmployeePunchForVerification(int intEmployeeID, DateTime datStartDate, DateTime datEndDate, decimal decDailyHours)
        {
            try
            {
                aFindAholaEmployeePunchForVerificationDataSet = new FindAholaEmployeePunchForVerificationDataSet();
                aFindAholaEmployeePunchForVerificationTableAdapter = new FindAholaEmployeePunchForVerificationDataSetTableAdapters.FindAholaEmployeePunchForVerificationTableAdapter();
                aFindAholaEmployeePunchForVerificationTableAdapter.Fill(aFindAholaEmployeePunchForVerificationDataSet.FindAholaEmployeePunchForVerification, intEmployeeID, datStartDate, datEndDate, decDailyHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Ahola Employee Punch For Verification " + Ex.Message);
            }

            return aFindAholaEmployeePunchForVerificationDataSet;
        }
        public bool InsertIntoAholaEmployeePunch(int intEmployeeID, DateTime datStartDate, DateTime datEndDate, decimal decDailyHours)
        {
            bool blnFatalError = false;

            try
            {
                aInsertIntoAholaEmployeePunchTableAdapter = new InsertIntoAholaEmployeePunchEntryTableAdapters.QueriesTableAdapter();
                aInsertIntoAholaEmployeePunchTableAdapter.InsertIntoAholaEmployeePunch(intEmployeeID, datStartDate, datEndDate, decDailyHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Insert Into Ahola Employee Punch " + Ex.Message);
            }

            return blnFatalError;
        }
        public AlohaEmployeePunchesDataSet GetAlohaEmployeePunchesInfo()
        {
            try
            {
                aAlohaEmployeePunchesDataSet = new AlohaEmployeePunchesDataSet();
                aAlohaEmployeePunchesTableAdapter = new AlohaEmployeePunchesDataSetTableAdapters.alohaemployeepunchesTableAdapter();
                aAlohaEmployeePunchesTableAdapter.Fill(aAlohaEmployeePunchesDataSet.alohaemployeepunches);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Get Aloha Employee Info " + Ex.Message);
            }

            return aAlohaEmployeePunchesDataSet;
        }
        public void UpdateAholaEmployeePunchesDB(AlohaEmployeePunchesDataSet aAlohaEmployeePunchesDataSet)
        {
            try
            {
                aAlohaEmployeePunchesTableAdapter = new AlohaEmployeePunchesDataSetTableAdapters.alohaemployeepunchesTableAdapter();
                aAlohaEmployeePunchesTableAdapter.Update(aAlohaEmployeePunchesDataSet.alohaemployeepunches);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Updated Aloha Employee DB " + Ex.Message);
            }
        }
        public bool RemoveEmployeePunchedHours(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveEmployeePunchedHoursTableAdapter = new RemoveEmplolyeePunchedHoursEntryTableAdapters.QueriesTableAdapter();
                aRemoveEmployeePunchedHoursTableAdapter.RemoveEmployeePunchedHours(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Remove Employee Punched Hours " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindDuplicateEmployeePunchedHoursDataSet FindDuplicateEmployeePunchedHours(DateTime datTransactionDate)
        {
            try
            {
                aFindDuplicateEmployeePunchedHoursDataSet = new FindDuplicateEmployeePunchedHoursDataSet();
                aFindDuplicateEmployeePunchedHoursTableAdpater = new FindDuplicateEmployeePunchedHoursDataSetTableAdapters.FindDuplicateEmployeePunchedHoursTableAdapter();
                aFindDuplicateEmployeePunchedHoursTableAdpater.Fill(aFindDuplicateEmployeePunchedHoursDataSet.FindDuplicateEmployeePunchedHours, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Duplicate Employee Punched Hours " + Ex.Message);
            }

            return aFindDuplicateEmployeePunchedHoursDataSet;
        }
        public FindEmployeesOverFortyHoursDataSet FindEmployeesOverFortyHours(DateTime datPayPeriod)
        {
            try
            {
                aFindEmployeesOverFortyHoursDataSet = new FindEmployeesOverFortyHoursDataSet();
                aFindEmployeesOverFortyHoursTableAdapter = new FindEmployeesOverFortyHoursDataSetTableAdapters.FindEmployeesOverFortyHoursTableAdapter();
                aFindEmployeesOverFortyHoursTableAdapter.Fill(aFindEmployeesOverFortyHoursDataSet.FindEmployeesOverFortyHours, datPayPeriod);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Employees Over Forty Hours " + Ex.Message);
            }

            return aFindEmployeesOverFortyHoursDataSet;
        }
        public FindEmployeePunchesByManagerIDDataSet FindEmployeePunchesByManagerID(int intManagerID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeePunchesByManagerIDDataSet = new FindEmployeePunchesByManagerIDDataSet();
                aFindEmployeePunchesByManagerIDTableAdapter = new FindEmployeePunchesByManagerIDDataSetTableAdapters.FindEmployeePunchesByManagerIDTableAdapter();
                aFindEmployeePunchesByManagerIDTableAdapter.Fill(aFindEmployeePunchesByManagerIDDataSet.FindEmployeePunchesByManagerID, intManagerID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Employee Punches By Manager ID " + Ex.Message);
            }

            return aFindEmployeePunchesByManagerIDDataSet;
        }
        public FindAllEmployeePunchedHoursDataSet FindAllEmployeesPunchedHours(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindAllEmployeePunchedHoursDataSet = new FindAllEmployeePunchedHoursDataSet();
                aFindAllEmployeePunchedHoursTableAdapter = new FindAllEmployeePunchedHoursDataSetTableAdapters.FindAllEmployeePunchedHoursTableAdapter();
                aFindAllEmployeePunchedHoursTableAdapter.Fill(aFindAllEmployeePunchedHoursDataSet.FindAllEmployeePunchedHours, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find All Employees Punched Hours " + Ex.Message);
            }

            return aFindAllEmployeePunchedHoursDataSet;
        }
        public FindEmployeePunchedHoursDataSet FindEmployeePunchedHours(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindEmployeePunchedHoursDataSet = new FindEmployeePunchedHoursDataSet();
                aFindEmployeePunchedHoursTableAdapter = new FindEmployeePunchedHoursDataSetTableAdapters.FindEmployeePunchedHoursTableAdapter();
                aFindEmployeePunchedHoursTableAdapter.Fill(aFindEmployeePunchedHoursDataSet.FindEmployeePunchedHours, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Find Employee Punched Hours " + Ex.Message);
            }

            return aFindEmployeePunchedHoursDataSet;
        }
        public bool InsertEmployeePunchedHours(DateTime datTransactionDate, int intEmployeeID, int intPayID, decimal decHours)
        {
            bool blnFatatError = false;

            try
            {
                aInsertEmployeePunchedHoursTableAdapter = new InsertEmployeePunchedHoursEntryTableAdapters.QueriesTableAdapter();
                aInsertEmployeePunchedHoursTableAdapter.InsertEmployeePunchedHours(datTransactionDate, intEmployeeID, intPayID, decHours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Insert Employee Punched Hours " + Ex.Message);

                blnFatatError = true;
            }

            return blnFatatError;
        }
        public EmployeePunchedHoursDataSet GetEmployeePunchedHoursInfo()
        {
            try
            {
                aEmployeePunchedHoursDataSet = new EmployeePunchedHoursDataSet();
                aEmployeePunchedHoursTableAdapter = new EmployeePunchedHoursDataSetTableAdapters.employeepunchedhoursTableAdapter();
                aEmployeePunchedHoursTableAdapter.Fill(aEmployeePunchedHoursDataSet.employeepunchedhours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Get Employee Punched Hours Info " + Ex.Message);
            }

            return aEmployeePunchedHoursDataSet;
        }
        public void UpdateEmployeePunchedHoursDB(EmployeePunchedHoursDataSet aEmployeePunchedHoursDataSet)
        {
            try
            {
                aEmployeePunchedHoursTableAdapter = new EmployeePunchedHoursDataSetTableAdapters.employeepunchedhoursTableAdapter();
                aEmployeePunchedHoursTableAdapter.Update(aEmployeePunchedHoursDataSet.employeepunchedhours);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Punched Hours Class // Update Employee Punched Hours DB " + Ex.Message);
            }
        }
    }
}
