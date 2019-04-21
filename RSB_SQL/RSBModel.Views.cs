//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(RSB_SQL.RSBEntities),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets6648acc1e456ac55d4e5ba2d418707f515b1cf065338bc3a907894e0518fb07f))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.2.0")]
    internal sealed class ViewsForBaseEntitySets6648acc1e456ac55d4e5ba2d418707f515b1cf065338bc3a907894e0518fb07f : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "6648acc1e456ac55d4e5ba2d418707f515b1cf065338bc3a907894e0518fb07f"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "RSBModelStoreContainer.RSBDiary")
            {
                return GetView0();
            }

            if (extentName == "RSBEntities.RSBDiary")
            {
                return GetView1();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for RSBModelStoreContainer.RSBDiary.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing RSBDiary
        [RSBModel.Store.RSBDiary](T1.RSBDiary_id, T1.RSBDiary_jurisdiction, T1.[RSBDiary.case_name], T1.[RSBDiary.case_no], T1.[RSBDiary.hearing_date], T1.RSBDiary_judge, T1.[RSBDiary.transcript_particular_type_id], T1.[RSBDiary.is_daily], T1.[RSBDiary.sound_type_id], T1.[RSBDiary.sound_centre_id], T1.[RSBDiary.transcript_copy_type_id], T1.[RSBDiary.tr_cancelled_date], T1.[RSBDiary.level8_copy_date], T1.[RSBDiary.completed_by_name], T1.[RSBDiary.actual_num_of_pages], T1.[RSBDiary.estimated_num_of_pages], T1.[RSBDiary.reporters_list], T1.[RSBDiary.private_contractor_id], T1.[RSBDiary.is_handed_down], T1.RSBDiary_comments, T1.[RSBDiary.cancel_reason])
    FROM (
        SELECT 
            T.id AS RSBDiary_id, 
            T.jurisdiction AS RSBDiary_jurisdiction, 
            T.case_name AS [RSBDiary.case_name], 
            T.case_no AS [RSBDiary.case_no], 
            T.hearing_date AS [RSBDiary.hearing_date], 
            T.judge AS RSBDiary_judge, 
            T.transcript_particular_type_id AS [RSBDiary.transcript_particular_type_id], 
            T.is_daily AS [RSBDiary.is_daily], 
            T.sound_type_id AS [RSBDiary.sound_type_id], 
            T.sound_centre_id AS [RSBDiary.sound_centre_id], 
            T.transcript_copy_type_id AS [RSBDiary.transcript_copy_type_id], 
            T.tr_cancelled_date AS [RSBDiary.tr_cancelled_date], 
            T.level8_copy_date AS [RSBDiary.level8_copy_date], 
            T.completed_by_name AS [RSBDiary.completed_by_name], 
            T.actual_num_of_pages AS [RSBDiary.actual_num_of_pages], 
            T.estimated_num_of_pages AS [RSBDiary.estimated_num_of_pages], 
            T.reporters_list AS [RSBDiary.reporters_list], 
            T.private_contractor_id AS [RSBDiary.private_contractor_id], 
            T.is_handed_down AS [RSBDiary.is_handed_down], 
            T.comments AS RSBDiary_comments, 
            T.cancel_reason AS [RSBDiary.cancel_reason], 
            True AS _from0
        FROM RSBEntities.RSBDiary AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for RSBEntities.RSBDiary.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing RSBDiary
        [RSBModel.RSBDiary](T1.RSBDiary_id, T1.RSBDiary_jurisdiction, T1.[RSBDiary.case_name], T1.[RSBDiary.case_no], T1.[RSBDiary.hearing_date], T1.RSBDiary_judge, T1.[RSBDiary.transcript_particular_type_id], T1.[RSBDiary.is_daily], T1.[RSBDiary.sound_type_id], T1.[RSBDiary.sound_centre_id], T1.[RSBDiary.transcript_copy_type_id], T1.[RSBDiary.tr_cancelled_date], T1.[RSBDiary.level8_copy_date], T1.[RSBDiary.completed_by_name], T1.[RSBDiary.actual_num_of_pages], T1.[RSBDiary.estimated_num_of_pages], T1.[RSBDiary.reporters_list], T1.[RSBDiary.private_contractor_id], T1.[RSBDiary.is_handed_down], T1.RSBDiary_comments, T1.[RSBDiary.cancel_reason])
    FROM (
        SELECT 
            T.id AS RSBDiary_id, 
            T.jurisdiction AS RSBDiary_jurisdiction, 
            T.case_name AS [RSBDiary.case_name], 
            T.case_no AS [RSBDiary.case_no], 
            T.hearing_date AS [RSBDiary.hearing_date], 
            T.judge AS RSBDiary_judge, 
            T.transcript_particular_type_id AS [RSBDiary.transcript_particular_type_id], 
            T.is_daily AS [RSBDiary.is_daily], 
            T.sound_type_id AS [RSBDiary.sound_type_id], 
            T.sound_centre_id AS [RSBDiary.sound_centre_id], 
            T.transcript_copy_type_id AS [RSBDiary.transcript_copy_type_id], 
            T.tr_cancelled_date AS [RSBDiary.tr_cancelled_date], 
            T.level8_copy_date AS [RSBDiary.level8_copy_date], 
            T.completed_by_name AS [RSBDiary.completed_by_name], 
            T.actual_num_of_pages AS [RSBDiary.actual_num_of_pages], 
            T.estimated_num_of_pages AS [RSBDiary.estimated_num_of_pages], 
            T.reporters_list AS [RSBDiary.reporters_list], 
            T.private_contractor_id AS [RSBDiary.private_contractor_id], 
            T.is_handed_down AS [RSBDiary.is_handed_down], 
            T.comments AS RSBDiary_comments, 
            T.cancel_reason AS [RSBDiary.cancel_reason], 
            True AS _from0
        FROM RSBModelStoreContainer.RSBDiary AS T
    ) AS T1");
        }
    }
}
